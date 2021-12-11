using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMMW.ViewModel
{
    public class BubbleFactory
    {
        private readonly BubbleBrustMatrixModel _bubbleMatrix;
        private readonly List<BubbleViewModel> _bubbleStagingArea;

        /// <summary>Initializes a new instance of the <see cref="BubbleFactory"/> class.</summary>
        /// <param name="bubbleMatrix">The bubble matrix.</param>
        /// <exception cref="System.ArgumentNullException">bubbleMatrix</exception>
        internal BubbleFactory(BubbleBrustMatrixModel bubbleMatrix)
        {
            if (bubbleMatrix == null)
                throw new ArgumentNullException("bubbleMatrix");

            _bubbleMatrix = bubbleMatrix;

            _bubbleStagingArea = new List<BubbleViewModel>();

            _bubbleStagingArea.Clear();
            _bubbleStagingArea.AddRange(
            from row in Enumerable.Range(0, 8)
            from col in Enumerable.Range(0, 8)
            select new BubbleViewModel(_bubbleMatrix, row, col));


            for (var i = 0; i < 64; ++i)
            {
                var bubble = _bubbleStagingArea[i];
                // Add the bubble to the bubble matrix.
                _bubbleMatrix.AddBubble(bubble);
            }
            _bubbleMatrix.IsIdle = true;
        }

    }
}
