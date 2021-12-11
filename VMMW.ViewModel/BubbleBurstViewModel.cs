using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMMW.ViewModel
{
    public class BubbleBurstViewModel
    {

        public BubbleBurstViewModel()
        {
            BubbleMatrix = new BubbleBrustMatrixModel();
        }
        public BubbleBrustMatrixModel BubbleMatrix { get; private set; }
    }
}
