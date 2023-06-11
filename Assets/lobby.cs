using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Lobbies.Models;
using Unity.Services.Lobbies;
using UnityEngine;
using UnityEngine.Networking;

public class lobby : MonoBehaviour
{
    private async Task Start()
    {
        await UnityServices.InitializeAsync();
        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log("Signed In " + AuthenticationService.Instance.PlayerId);
        };
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    [System.Runtime.CompilerServices.AsyncStateMachine(typeof(CreateLobbyStateMachine))]
    private async void CreateLobby()
    {
        try
        {
            string lobbyName = "MyLobby";
            int maxPlayers = 4;
            Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers);

            Debug.Log("Created Lobby! " + " " + lobby.MaxPlayers);
        }
        catch (LobbyServiceException e)
        {
            Debug.Log(e);
        }
    }

    void Update()
    {

    }
    private struct CreateLobbyStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public void MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
        {
            throw new System.NotImplementedException();
        }
    }
}