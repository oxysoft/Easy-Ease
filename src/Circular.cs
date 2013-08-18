using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ld27warmup.Util.Easing.Core;

namespace ld27warmup.Util.Easing {
	public class Circular {
		public static IEasing EaseIn = new In();
		public static IEasing EaseOut = new Out();
		public static IEasing EaseInOut = new InOut();

		private class In : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d;
				return (float) (-c * (Math.Sqrt(1 - t * t) - 1) + b);
			}
		}

		private class Out : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d;
				t--;
				return (float) (c * Math.Sqrt(1 - t * t) + b);
			}
		}

		private class InOut : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d / 2;
				if (t < 1) return (float) (-c / 2 * (Math.Sqrt(1 - t * t) - 1) + b);
				t -= 2;
				return (float) (c / 2 * (Math.Sqrt(1 - t * t) + 1) + b);
			}
		}
	}
}