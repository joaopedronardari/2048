using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2048.WPF
{
    class RealSenseManager
    {
        // TODO - 1. Components

        public OnGameGestureFired gameGestureFired;

        public RealSenseManager(OnGameGestureFired gameGestureFired)
        {
            this.gameGestureFired = gameGestureFired;

            // TODO - 2. Constructor
        }

        public void Start() 
        {
            // TODO - 3. Start Method
        }

        private void IterateFrames()
        {
            // TODO - 4. Iterate Frames Method
        }

        private void ProcessGestures(PXCMHandData handData)
        {
            // TODO - 5. Process Gestures Method
        }

        private void ReleaseResources()
        {
            // TODO - 6. Release Resources Method
        }

        public void Stop()
        {
            // TODO - 7. Stop Method
        }
    }
}
