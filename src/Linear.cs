using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ld27warmup.Util.Easing.Core;

namespace ld27warmup.Util.Easing {
	public class Linear {
		public static IEasing NoEase = new In();

		protected class In : IEasing {
			public float Ease(float t, float b, float c, float d) {
				return c * t / d + b;
			}
		}
	}
}