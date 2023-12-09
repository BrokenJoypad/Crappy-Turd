using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    [Header("Speed Values")]
    [SerializeField, Range(0, 5)] float MovementSpeed = 2.5f;

    [Header("Scale Values")]
    [SerializeField, Range(0, 10)] float MinimumScaleRange = 0.5f;
    [SerializeField, Range(0, 10)] float MaximumScaleRange = 1f;

    [Header("Position Values")]
    [SerializeField, Range(-10, 0)] float MinimumPositionRange = -3.5f;
    [SerializeField, Range(0, 10)] float MaximumPositionRange = 3.5f;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        RandomizeScaleAndPosition();
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.ReturnPlayerState())
        {
            MoveTowardsEdge();
            CheckPositionAndDestroy();
        }

    }

    void MoveTowardsEdge()
    {
        gameObject.transform.Translate(-1 * MovementSpeed * Time.deltaTime, 0, 0);
    }

    void CheckPositionAndDestroy()
    {
        if (gameObject.transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }

    void RandomizeScaleAndPosition()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, Random.Range(MinimumScaleRange, MaximumScaleRange), gameObject.transform.localScale.z);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, Random.Range(MinimumPositionRange, MaximumPositionRange), gameObject.transform.position.z);

    }

}
