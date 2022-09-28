using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailSpawn : MonoBehaviour
{
    public List<GameObject> SnakeTail = new List<GameObject>();
    public List<Vector3> PositionsHistory = new List<Vector3>();
    public GameObject TailPrefab;
    protected int Gap = 5;
    protected float BodySpeed = 5;
    public float SnakeLength = 3;
    public GameOver GameOverPanel;
    public string TagBlock;

    private void Start()
    {
        AddTail();
        AddTail();
        AddTail();
        AddTail();
    }
    private void FixedUpdate()
    {
        SnakeLength = SnakeTail.Count;

        PositionsHistory.Insert(0, transform.position);
        int index = 0;
        foreach (var tail in SnakeTail)
        {
            Vector3 point = PositionsHistory[Mathf.Min(index * Gap, PositionsHistory.Count - 1)];
            Vector3 moveDirection = point - tail.transform.position;
            tail.transform.position += moveDirection * BodySpeed * Time.deltaTime;
            tail.transform.LookAt(point);
            index++;
        }
        Lose();
    }
    public void AddTail()
    {
        GameObject tail = Instantiate(TailPrefab);
        SnakeTail.Add(tail);
    }
    public void RemoveTail()
    {
        Destroy(SnakeTail[0]);
        SnakeTail.RemoveAt(0);
        PositionsHistory.RemoveAt(0);
    }
    void Lose()
    {
        if (SnakeLength <= 0)
        {
            GameOverPanel.Setup();
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collBlock)
    {
        if (collBlock.gameObject.tag == TagBlock)
        {
            transform.Translate(new Vector3(0, 0, -1));
            RemoveTail();
        }
    }
}
