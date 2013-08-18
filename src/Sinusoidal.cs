using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ld27warmup.Util.Easing.Core;

namespace ld27warmup.Util.Easing {
	public class Sinusoidal {
		public static IEasing EaseIn = new In();
		public static IEasing EaseOut = new Out();
		public static IEasing EaseInOut = new InOut();

		private class In : IEasing {
			public float Ease(float t, float b, float c, float d) {
				return (float) (-c * Math.Cos(t / d * (Math.PI / 2)) + c + b);
			}
		}

		private class Out : IEasing {
			public float Ease(float t, float b, float c, float d) {
				return (float) (c * Math.Sin(t / d * (Math.PI / 2)) + b);
			}
		}

		private class InOut : IEasing {
			public float Ease(float t, float b, float c, float d) {
				return (float) (-c / 2 * (Math.Cos(Math.PI * t / d) - 1) + b);
			}
		}
	}
}