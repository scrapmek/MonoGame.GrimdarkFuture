﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GrimdarkFuture.Application.Helpers
{
	public static class Helpers
	{
		private static Texture2D lineTexture;

		public static void DrawLine(this SpriteBatch spriteBatch, Vector2 point1, Vector2 point2, Color color, float thickness = 1f)
		{
			var distance = Vector2.Distance(point1, point2);
			var angle = (float)Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);
			DrawLine(spriteBatch, point1, distance, angle, color, thickness);
		}

		public static void DrawLine(this SpriteBatch spriteBatch, Vector2 point, float length, float angle, Color color, float thickness = 1f)
		{
			var origin = new Vector2(0f, 0.5f);
			var scale = new Vector2(length, thickness);
			spriteBatch.Draw(GetTexture(spriteBatch), point, null, color, angle, origin, scale, SpriteEffects.None, 0);
		}

		private static Texture2D GetTexture(SpriteBatch spriteBatch)
		{
			if (lineTexture == null)
			{
				lineTexture = new Texture2D(spriteBatch.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
				lineTexture.SetData(new[] { Color.White });
			}

			return lineTexture;
		}
	}
}