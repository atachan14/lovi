using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkManagerController : MonoBehaviour
{
    void OnGUI()
    {
        if (!NetworkManager.Singleton.IsServer && !NetworkManager.Singleton.IsClient)
        {
            // �T�[�o�[�J�n�{�^��
            if (GUILayout.Button("Start Server"))
            {
                NetworkManager.Singleton.StartServer();
            }

            // �N���C�A���g�J�n�{�^��
            if (GUILayout.Button("Start Client"))
            {
                NetworkManager.Singleton.StartClient();
            }

            // �z�X�g�J�n�{�^��
            if (GUILayout.Button("Start Host"))
            {
                NetworkManager.Singleton.StartHost();
            }
        }
        else
        {
            GUILayout.Label($"Connection Status: {(NetworkManager.Singleton.IsServer ? "Server" : "Client")}");
            GUILayout.Label($"Connected Clients: {NetworkManager.Singleton.ConnectedClients.Count}");
        }
    }
}