using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfApplication
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "MagicNumberService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы MagicNumberService.svc или MagicNumberService.svc.cs в обозревателе решений и начните отладку.
    public class MagicNumberService : IMagicNumberService
    {
        public Int16 MagicNumber()
        {
            return (42);
        }
    }
}
