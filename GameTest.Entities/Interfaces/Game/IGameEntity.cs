﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace GameTest.Entities.Interfaces
{
	public interface IGameEntity
	{
		GameTime LastUpdated { get; }
		void Update(GameTime time);

		void LoadAssets(ContentManager content);
	}
}

