using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formulas
{
    public float Pow(float x)
    {
        return x * x;
    }
    public float Magnitud(Vector3 vector)
    {
        float x = vector.x * vector.x;
        float y = vector.y * vector.y;
        float z = vector.z * vector.z;

        float sum = x + y + z;

        float result = Mathf.Sqrt(sum);

        return result;
    }

    public Vector3 Normalizar(Vector3 vector)
    {
        float x = vector.x / Magnitud(vector);
        float y = vector.y / Magnitud(vector);
        float z = vector.z / Magnitud(vector);
        vector = new Vector3(x, y, z);

        return vector;
    }
    public Vector3 Translacion(Vector3 pos, Vector3 delta)
    {
        Vector3 resultado;

        resultado.x = (1 * pos.x) + (0 * pos.y) + (0 * pos.z) + (delta.x * 1);
        resultado.y = (0 * pos.x) + (1 * pos.y) + (0 * pos.z) + (delta.y * 1);
        resultado.z = (0 * pos.x) + (0 * pos.y) + (1 * pos.z) + (delta.z * 1);

        return resultado;

    }

    public Vector3 RotZ(Vector3 pos, float angle)
    {
        float a = Mathf.Deg2Rad * angle;

        Vector3 resultado;

        resultado.x = (Mathf.Cos(a) * pos.x) + (-Mathf.Sin(a) * pos.y) + (0 * pos.z) + (0 * 1);
        resultado.y = (Mathf.Sin(a) * pos.x) + (Mathf.Cos(a) * pos.y) + (0 * pos.z) + (0 * 1);
        resultado.z = (0 * pos.x) + (0 * pos.y) + (1 * pos.z) + (0 * 1);

        return resultado;
    }

    public Vector3 Quaternion(Vector3 eje, float angle, Vector3 pos)
    {
        //q = w + v
        float a = Mathf.Deg2Rad * angle;
        float w = Mathf.Cos(a / 2);

        eje = Normalizar(eje);

        Vector3 v;

        v.x = eje.x * Mathf.Sin(a / 2);
        v.y = eje.y * Mathf.Sin(a / 2);
        v.z = eje.z * Mathf.Sin(a / 2);


        Matrix4x4 matrix = Matrix4x4.identity;

        matrix.m00 = 1 - 2 * Pow(v.y) - 2 * Pow(v.z);
        matrix.m01 = 2 * v.x * v.y - 2 * w * v.z;
        matrix.m02 = 2 * v.x * v.z + 2 * w * v.y;
        matrix.m10 = 2 * v.x * v.y + 2 * w * v.z;
        matrix.m11 = 1 - 2 * Pow(v.x) - 2 * Pow(v.z);
        matrix.m12 = 2 * v.y * v.z - 2 * w * v.x;
        matrix.m20 = 2 * v.x * v.z - 2 * w * v.y;
        matrix.m21 = 2 * v.y * v.z + 2 * w * v.x;
        matrix.m22 = 1 - 2 * Pow(v.x) - 2 * Pow(v.y);

        Vector3 result = matrix * pos;

        return result;
    }

}

