using System.Collections.Generic;
using MVVM_pr7.Model;

namespace MVVM_pr7.View
{
    public interface OpenSave
    {

        List<SmokeModel> Open(string filename);
        void Save(string filename, List<SmokeModel> smokesList);
    }
}
