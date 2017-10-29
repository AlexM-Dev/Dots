using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dots {
    public class FPS {
        #region Basic Frame Counter

        private static int lastTick;
        private static int lastFrameRate;
        private static int frameRate;

        public static int CalculateFrameRate() {
            if (Environment.TickCount - lastTick >= 1000) {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = Environment.TickCount;
            }
            frameRate++;
            return lastFrameRate;
        }
        #endregion

    }
}
