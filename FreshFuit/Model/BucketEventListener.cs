using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFuit.Model
{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }
}
