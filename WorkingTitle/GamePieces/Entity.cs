using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WorkingTitle.GamePieces {
	public abstract class Entity {
		public Texture2D Sprite;

		private float _XPosition;
		public float XPosition{
			get{
				return _XPosition;
			}
			set{
				_XPosition = value;
			}
		}
		private float _YPosition;
		public float YPosition{
			get{
				return _YPosition;
			}
			set{
				_YPosition = value;
			}
		}

		public Entity(Texture2D Sprite){
			this.Sprite = Sprite;
		}

		public Vector2 GetPosition(){
			return new Vector2(XPosition, YPosition);
		}
	}
}
