﻿using GrimdarkFuture.Entities.Interfaces.Game;
using Microsoft.Xna.Framework.Graphics;

namespace GrimdarkFuture.Application
{
	public class Renderer
	{
		private readonly EntityStore entityStore;

		public Renderer(EntityStore entityStore)
		{
			this.entityStore = entityStore;
		}

		public void Render(SpriteBatch spriteBatch)
		{
			foreach (var item in entityStore.GetEntitiesByType<IGameEntity>())
				item.Draw(spriteBatch);
		}
	}
}