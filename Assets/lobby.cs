public class lobby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start();

    private async void start()
 {   
        await UnityServices.InitializeAsync();
        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log("Signed In " + AuthenticationService.Instance.PlayerId);
        };
        object p1    await AuthenticationService.Instance.SignInAnonymouslyAsync();
        [Command]
        {

        }

        private async void CreateLobby()
        {
            try
            {
                string Lobbyname = "MyLobby";
                int maxplayers 4();
                Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(LobbyName, maxPlayers);

                Debug.log("Created Lobby! " + " " + lobby.MaxPlayers);

              catch (LobbyServiceExeception e {
                Debug.Log(e);
             }
              // Update is called once per frame
             void Update()
              {

               }
            }                   
        }