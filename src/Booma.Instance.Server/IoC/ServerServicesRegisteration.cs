﻿using Booma.Instance.Common;
using SceneJect.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Instance.Server
{
	public class ServerServicesRegisteration : NonBehaviourDependency
	{
		public override void Register(IServiceRegister register)
		{
			//Just create a new collection and register it
			INetworkPlayerEntityCollection playerCollection = new NetworkPlayerEntityCollection();

			//Register as both for now
			register.Register<INetworkPlayerEntityCollection>(playerCollection, RegistrationType.SingleInstance);
			register.Register<IPlayerEntityCollection>(playerCollection, RegistrationType.SingleInstance);
		}
	}
}
