﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class fieldOfView : MonoBehaviour
{
	//public float distance;
	//public static bool queriesHitBackfaces;


	public float viewRadius;
	[Range(0, 360)]
	public float viewAngle;

	public LayerMask targetMask;
	public LayerMask obstacleMask;

	[HideInInspector]
	public List<Transform> visibleTargets = new List<Transform>();

	public float meshResolution; 

	void Start()
	{
		StartCoroutine("FindTargetsWithDelay", .2f);
		//queriesHitBackfaces = false;
	}


	IEnumerator FindTargetsWithDelay(float delay)
	{
		while (true)
		{
			yield return new WaitForSeconds(delay);
			FindVisibleTargets();
		}
	}

	void Update()
    {
		DrawFieldOfView();
		

	}

		void FindVisibleTargets()
	{
		visibleTargets.Clear();
		Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, targetMask);

		for (int i = 0; i < targetsInViewRadius.Length; i++)
		{
			Transform target = targetsInViewRadius[i].transform;
			Vector3 dirToTarget = (target.position - transform.position).normalized;
			if (Vector3.Angle(transform.forward, dirToTarget) < viewAngle / 2)
			{
				float dstToTarget = Vector3.Distance(transform.position, target.position);

				if (!Physics.Raycast(transform.position, dirToTarget, dstToTarget, obstacleMask))
				{
					visibleTargets.Add(target);
				}
			}
		}
	}

	void DrawFieldOfView()
	{
		int stepCount = Mathf.RoundToInt(viewAngle * meshResolution); //important!!
		float stepAngleSize = viewAngle / stepCount;
		List<Vector3> viewPoints = new List<Vector3>();


		for (int i = 0; i <= stepCount; i++)
		{
			float angle = transform.eulerAngles.y - viewAngle / 2 + stepAngleSize * i;
			ViewCastInfo newViewCast = ViewCast(angle);
			viewPoints.Add(newViewCast.point);
			//Debug.DrawLine(transform.position, transform.position + DirFromAngle(angle, true) * viewRadius, Color.green);

		}
	}

		ViewCastInfo ViewCast(float globalAngle)
		{
			Vector3 dir = DirFromAngle(globalAngle, true);
			RaycastHit hit;

			if (Physics.Raycast(transform.position, dir, out hit, viewRadius, obstacleMask))
			{
				return new ViewCastInfo(true, hit.point, hit.distance, globalAngle);
			
		}
			else
			{
				return new ViewCastInfo(false, transform.position + dir * viewRadius, viewRadius, globalAngle);
			}
		}

		//if (Physics.Raycast(transform.position, transform.right, out hitInfo, distance))
		//{
		// Debug.DrawLine(transform.position, hitInfo.point, Color.red);
		//Debug.DrawLine(transform.position, transform.position + DirFromAngle(angle, true) * viewRadius, Color.red);

		//}

		//else
		//{
		//	Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
		//    
		//     
		//}

	



	public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
	{
		if (!angleIsGlobal)
		{
			angleInDegrees += transform.eulerAngles.y;
		}
		return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
	}

	public struct ViewCastInfo
    {
		public bool hit;
		public Vector3 point;
		public float dst;
		public float angle; 

		public ViewCastInfo(bool _hit, Vector3 _point, float _dst, float _angle)
        {
			hit = _hit;
			point = _point;
			dst = _dst;
			angle = _angle;
		}
    }
}



