using UnityEngine;
using Fusion;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public GameObject PlayerPrefab;
   
    private void Start()
    {
       
    }
    
    public void PlayerJoined(PlayerRef player)
    {
        if(player == Runner.LocalPlayer)
        {
            NetworkObject networkObject= Runner.Spawn(PlayerPrefab, new Vector3(0, 1, 0),Quaternion.identity);
        }
    }
}