using System.Collections.Generic;
using UnityEngine;
using Colyseus;
using static Dissonity.Api;

// You need to place the generated C# classes from running "npm run colyseus"
// inside the Unity project.

public class MultiplayerExample : MonoBehaviour
{
    ColyseusClient client;
    ColyseusRoom<GameState> room;

    async void Start()
    {
        // Initialize Dissonity
        await Initialize();

        // Connect to server
        client = new ColyseusClient("wss://<your-app-id>.discordsays.com/.proxy");

        // Create or join the activity room
        room = await client.JoinOrCreate<GameState>("game", new Dictionary<string, object>{
            { "instanceId", InstanceId },
            { "userId", UserId.ToString() }
        });

        // Client is now connected to the room!
    }
}