using UnityEngine;
using UnityEngine.Tilemaps;

public class TileClickReplace : MonoBehaviour
{
    public Tilemap tilemap;          // 에디터에서 연결
    public TileBase replaceTile;     // 교체할 타일 에셋

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPos = tilemap.WorldToCell(mouseWorld);
            TileBase current = tilemap.GetTile(cellPos);

            if (current != null && replaceTile != null)
            {
                tilemap.SetTile(cellPos, replaceTile);
                tilemap.RefreshTile(cellPos);
            }
        }
    }
}