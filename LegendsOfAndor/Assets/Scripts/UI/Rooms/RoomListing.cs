using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class RoomListing : MonoBehaviour{
    [SerializeField]
    private Text _text;

    public RoomInfo RoomInfo { get; private set; }

    public void SetRoomInfo(RoomInfo roomInfo){
        RoomInfo = roomInfo;
        _text.text = roomInfo.Name + " " +roomInfo.PlayerCount + "/" + roomInfo.MaxPlayers;
    }

    public void OnClick_Button()
    {
        //clearMessages();
        PhotonNetwork.JoinRoom(RoomInfo.Name);
    }

    private void Update()
    {
        _text.text = RoomInfo.Name + " " + RoomInfo.PlayerCount + "/" + RoomInfo.MaxPlayers;
    }
}
