using UnityEngine;
using Fusion;

public class CoinSpawner : NetworkBehaviour
{
    public GameObject coinPrefab;

    public override void Spawned()
    {
        if (Object.HasStateAuthority)
        {
            StartCoroutine(SpawnCoinRoutine());
        }
    }

    private System.Collections.IEnumerator SpawnCoinRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f); // cứ 5s spawn 1 coin
            Vector2 randomPos = new Vector2(Random.Range(-5f, 6f), 5f); // spawn phía trên, để nó rơi xuống

            Runner.Spawn(coinPrefab, randomPos, Quaternion.identity, null);
        }
    }
}
