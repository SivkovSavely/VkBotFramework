﻿using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Model.GroupUpdate;

namespace VkBotFramework
{
	public partial class VkBot
	{
		public class GroupUpdateReceivedEventArgs : EventArgs
		{
			public GroupUpdateReceivedEventArgs(GroupUpdate update)
			{
				this.update = update;
			}
			public GroupUpdate update;
		}
	}
}
