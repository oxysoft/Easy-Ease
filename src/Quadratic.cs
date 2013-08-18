using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ld27warmup.Util.Easing.Core;

namespace ld27warmup.Util.Easing {
	public class Quadratic {
		public static IEasing EaseIn = new In();
		public static IEasing EaseOut = new Out();
		public static IEasing EaseInOut = new InOut();

		private class In : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d;
				return c * t * t + b;
			}
		}

		private class Out : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d;
				return -c * t * (t - 2) + b;
			}
		}

		private class InOut : IEasing {
			public float Ease(float t, float b, float c, float d) {
				t /= d / 2;
				if (t < 1) return c / 2 * t * t + b;
				t--;
				return -c / 2 * (t * (t - 2) - 1) + b;
			}
		}
	}
}