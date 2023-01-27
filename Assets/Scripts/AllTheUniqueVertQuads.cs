using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllTheUniqueVertQuads :AbstractMeshGenerator
{
    [SerializeField] private Vector3[] vs = new Vector3[4];
    protected override void SetMeshNums()
    {
        numVertices = 6;
        numTriangles = 6;
    }
    protected override void SetVertices()
    {
        vertices.AddRange (vs [0]);
        vertices.AddRange (vs [1]);
        vertices.AddRange (vs [2]);

        vertices.AddRange (vs [3]);
        vertices.AddRange (vs [4]);
        vertices.AddRange (vs [5]);
    }
    protected override void SetTriangles()
    {   
        //treangle one
        triangles.Add(0);
        triangles.Add(3);
        triangles.Add(2);

        //treangle one
        triangles.Add(0);
        triangles.Add(1);
        triangles.Add(3);

    }

    protected override void SetNormals ()
    {

    }
    protected override void SetTangents ()
    {

    }
    protected override void SetUVs ()
    {

    }
    protected override void SetVertexColours ()
    {

    }
}