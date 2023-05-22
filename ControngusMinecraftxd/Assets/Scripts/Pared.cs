using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Pared : MonoBehaviour
{
	public float sizex = 1f;
	public float sizey = 1f;
	public float sizez = 1f;
	void Start()
	{
		/*
		Vector3[] vertices = {
			new Vector3(0, sizey, 0),
			new Vector3(0, 0, 0),
			new Vector3(sizex, sizey, 0),
			new Vector3(sizex, 0, 0),

			new Vector3(0, 0, sizez),
			new Vector3(sizex, 0, sizez),
			new Vector3(0, sizey, sizez),
			new Vector3(sizex, sizey, sizez),

			new Vector3(0, sizey, 0),
			new Vector3(sizex, sizey, 0),

			new Vector3(0, sizey, 0),
			new Vector3(0, sizey, sizez),

			new Vector3(sizex, sizey, 0),
			new Vector3(sizex, sizey, sizez),
		};

		int[] triangles = {
			0, 2, 1, // front
			1, 2, 3,
			4, 5, 6, // back
			5, 7, 6,
			6, 7, 8, //top
			7, 9 ,8,
			1, 3, 4, //bottom
			3, 5, 4,
			1, 11,10,// left
			1, 4, 11,
			3, 12, 5,//right
			5, 12, 13


		};
		Vector2[] uvs = {
			new Vector2(0, 0.66f),
			new Vector2(0.25f, 0.66f),
			new Vector2(0, 0.33f),
			new Vector2(0.25f, 0.33f),

			new Vector2(0.5f, 0.66f),
			new Vector2(0.5f, 0.33f),
			new Vector2(0.75f, 0.66f),
			new Vector2(0.75f, 0.33f),

			new Vector2(1, 0.66f),
			new Vector2(1, 0.33f),

			new Vector2(0.25f, 1),
			new Vector2(0.5f, 1),

			new Vector2(0.25f, 0),
			new Vector2(0.5f, 0),
		};

		Mesh mesh = GetComponent<MeshFilter>().mesh;
		mesh.Clear();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.uv = uvs;
		mesh.Optimize();
		mesh.RecalculateNormals();
		*/
	}

    private void Update()
    {

		Vector3[] vertices = {
			new Vector3(0, sizey, 0),
			new Vector3(0, 0, 0),
			new Vector3(sizex, sizey, 0),
			new Vector3(sizex, 0, 0),

			new Vector3(0, 0, sizez),
			new Vector3(sizex, 0, sizez),
			new Vector3(0, sizey, sizez),
			new Vector3(sizex, sizey, sizez),

			new Vector3(0, sizey, 0),
			new Vector3(sizex, sizey, 0),

			new Vector3(0, sizey, 0),
			new Vector3(0, sizey, sizez),

			new Vector3(sizex, sizey, 0),
			new Vector3(sizex, sizey, sizez),
		};

		int[] triangles = {
			0, 2, 1, // front
			1, 2, 3,
			4, 5, 6, // back
			5, 7, 6,
			6, 7, 8, //top
			7, 9 ,8,
			1, 3, 4, //bottom
			3, 5, 4,
			1, 11,10,// left
			1, 4, 11,
			3, 12, 5,//right
			5, 12, 13


		};
		Vector2[] uvs = {
			new Vector2(0, 0.66f),
			new Vector2(0.25f, 0.66f),
			new Vector2(0, 0.33f),
			new Vector2(0.25f, 0.33f),

			new Vector2(0.5f, 0.66f),
			new Vector2(0.5f, 0.33f),
			new Vector2(0.75f, 0.66f),
			new Vector2(0.75f, 0.33f),

			new Vector2(1, 0.66f),
			new Vector2(1, 0.33f),

			new Vector2(0.25f, 1),
			new Vector2(0.5f, 1),

			new Vector2(0.25f, 0),
			new Vector2(0.5f, 0),
		};

		Mesh mesh = GetComponent<MeshFilter>().mesh;
		mesh.Clear();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.uv = uvs;
		mesh.Optimize();
		mesh.RecalculateNormals();
	}
}
