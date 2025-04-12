using UnityEngine;

public static class UtilExtensions
{
    #region Vector2 Angle Change
    public static Vector2Int Rotate90(this Vector2Int v) => new(-v.y, v.x);
    public static Vector2Int RotateMinus90(this Vector2Int v) => new(v.y, -v.x);
    #endregion

    #region Tuple Angle Change
    public static (int, int) Rotate90(this (int x, int y) t) => (-t.y, t.x);
    public static (int, int) RotateMinus90(this (int x, int y) t) => (t.y, -t.x);
    #endregion

    #if NOT_USE
    // 다양한 블럭이 돌아가는 모드 추가될 떄 언블럭
    public static List<Vector2Int> Rotate90(this List<Vector2Int> list)
    {
        var result = new List<Vector2Int>(list.Count);
        foreach (var v in list)
            result.Add(v.Rotate90());
        return result;
    }

    public static List<Vector2Int> RotateMinus90(this List<Vector2Int> list)
    {
        var result = new List<Vector2Int>(list.Count);
        foreach (var v in list)
            result.Add(v.RotateMinus90());
        return result;
    }
    public static List<(int, int)> Rotate90(this List<(int, int)> list)
    {
        var result = new List<(int, int)>(list.Count);
        foreach (var t in list)
            result.Add(t.Rotate90());
        return result;
    }

    public static List<(int, int)> RotateMinus90(this List<(int, int)> list)
    {
        var result = new List<(int, int)>(list.Count);
        foreach (var t in list)
            result.Add(t.RotateMinus90());
        return result;
    }
    #endif
}