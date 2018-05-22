using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationGrid : MonoBehaviour {

    public Transform prefabGrass;
    public Transform prefabTrail;

    PositionGrid Grass;
    PositionGrid Trail;

    /*
    private List<Vector2> posTrail = new List<Vector2>();
    private List<Vector2> posGrass = new List<Vector2>();

    private List<Transform> pos = new List<Transform>();
    */

	// Use this for initialization
	void Start () {

        Grass = new PositionGrid();
        Trail = new PositionGrid();

    }
	// X 15 y 9 || 280x160 ||
	public void Generation()
    {
        /*
        Grass.ClearObject();
        Trail.ClearObject();*/
        Instantiate(prefabGrass, new Vector2(-140, 0), Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform, false);
        Instantiate(prefabGrass, new Vector2(140, 0), Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform, false);
        Instantiate(prefabGrass, new Vector2(-140, 80), Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform, false);
        Instantiate(prefabGrass, new Vector2(-140, 60), Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform, false);

        Instantiate(prefabGrass, new Vector2(-140, 40), Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform, false);

        Instantiate(prefabGrass, new Vector2(-140, 20), Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform, false);

        Instantiate(prefabGrass, new Vector2(-120, 0), Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform, false);

    }

    Vector2[] PosTrail(int sizeX, int sizeY)
    {
        Vector2[] _pos = new Vector2[sizeX* sizeY];

        for(int i = 0, x=-140,y=-80; i<_pos.Length;i++)
        {

        }

        return _pos;
    }

    Vector2[] PosGrass(int sizeX, int sizeY)
    {
        Vector2[] _pos = new Vector2[sizeX * sizeY];

        for (int i = 0; i < _pos.Length; i++)
        {

        }

        return _pos;
    }

}

[System.Serializable]
public class PositionGrid
{
    private List<Vector2> posGrid = new List<Vector2>();
    private List<Transform> tranGrid = new List<Transform>();



    public void SetPositionGrid(Vector2 _posGrid, Transform _tranGrid)
    {
    posGrid.Add(_posGrid);
    tranGrid.Add(_tranGrid);
    }

    public void ClearObject()
    {
        posGrid.Clear();
        tranGrid.Clear();
    }
}