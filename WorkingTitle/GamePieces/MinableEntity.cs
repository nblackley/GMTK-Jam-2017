using System;
using Microsoft.Xna.Framework.Graphics;

namespace WorkingTitle.GamePieces {
	public class MinableEntity : Entity{
		public enum ResourceType{
			Tree,
			Rock
		}
		public int RemainingResources;
		public bool IsDepleted;

		public MinableEntity(int initialResources, Texture2D Sprite) : base(Sprite){
			RemainingResources = initialResources;
			IsDepleted = false;
		}
		/// <summary>
		/// Mine the specified amount if possible.
		/// </summary>
		/// <returns>The amount mined</returns>
		/// <param name="amount">Amount to mine</param>
		public int Mine(int amount) {
			if(RemainingResources >= amount){
				RemainingResources -= amount;
				return amount;
			}
			else {
				int remainder = RemainingResources;
				RemainingResources = 0;
				IsDepleted = true;
				return remainder;
			}
		}
	}
}
