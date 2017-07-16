using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WorkingTitle {
	public abstract class Entity {
		public static Texture2D Sprite;

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

		public Entity(){
			
		}

		public Vector2 GetPosition(){
			return new Vector2(XPosition, YPosition);
		}
	}
}
