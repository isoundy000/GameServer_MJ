﻿using System;
namespace GameServer_MJ
{
	public class HandlePlayerEvent
	{
		public void OnLogin(Player player)
		{
			
		}

		public void OnLogout(Player player)
		{
			if (player.tempData.status == PlayerTempData.Status.Room)
			{
				Room room = player.tempData.room;
				RoomManager.GetInstance().LeaveRoom(player);
				if (room != null)
					room.Broadcast(StaticValue.Server_GetRoomInfo, room.GetRoomInfo());
			}
		}
	}
}
