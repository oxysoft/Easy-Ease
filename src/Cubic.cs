using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ld27warmup.Util.Easing.Core;

namespace ld27warmup.Util.Easing {
	public class Cubic {
		public static IEasing EaseIn = new In();
		public static IEasing EaseOut = new Out();
		public static IEasing EaseInOut = new InOut();

		private class In : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d;
				return c * t * t * t + b;
			}
		}

		private class Out : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d;
				t--;
				return c * (t * t * t + 1) + b;
			}
		}

		private class InOut : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d / 2;
				if (t < 1) return c / 2 * t * t * t + b;
				t -= 2;
				return c / 2 * (t * t * t + 2) + b;
			}
		}
	}
}