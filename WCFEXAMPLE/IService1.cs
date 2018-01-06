using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFEXAMPLE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
       
        IList<Person> GetAllFishes();


        [OperationContract]
      
        Person GetFishById(int id);

        [OperationContract]
       
        Person AddFish(Person catch1);

        [OperationContract]
   
        void DeleteFish(int id);

        [OperationContract]
       
        void UpdateFish(Person c, int id);

        [OperationContract]
      
        IEnumerable<Person> GetFishesByName(string nameFragment);

        
        
        IEnumerable<string> GetAllFishesName();
    }
}
