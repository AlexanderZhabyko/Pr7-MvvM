using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using MVVM_pr7.View;

namespace MVVM_pr7.Model
{
    public class DerSer : OpenSave
    {
        public List<SmokeModel> Open(string filename)
        {
            List<SmokeModel> smokes = new List<SmokeModel>();
            DataContractJsonSerializer jsonFormatter =
                new DataContractJsonSerializer(typeof(List<SmokeModel>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                smokes = jsonFormatter.ReadObject(fs) as List<SmokeModel>;
            }

            return smokes;
        }

        public void Save(string filename, List<SmokeModel> smokesList)
        {
            DataContractJsonSerializer jsonFormatter =
                new DataContractJsonSerializer(typeof(List<SmokeModel>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, smokesList);
            }
        }
    }
}

