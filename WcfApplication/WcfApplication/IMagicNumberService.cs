using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfApplication
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IMagicNumberService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IMagicNumberService
    {
        [OperationContract]
        Int16 MagicNumber();
    }
}
