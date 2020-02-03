using ConsoleAppDataBSela.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela
{
    public class BaseSpecifiedConcreteClassConverter : DefaultContractResolver
    {
        protected override JsonConverter ResolveContractConverter(Type objectType)
        {
            if (typeof(AbstractItem).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                return null; // pretend TableSortRuleConvert is not specified (thus avoiding a stack overflow)
            return base.ResolveContractConverter(objectType);
        }
    }

    public class BaseConverter : JsonConverter
    {
        static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(AbstractItem));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            switch (jo["ObjType"].Value<int> ())
            {
                case (int)AbstractItemId.Backpack:
                    return JsonConvert.DeserializeObject<Backpack>(jo.ToString(), SpecifiedSubclassConversion);
                case (int)AbstractItemId.Hat:
                    return JsonConvert.DeserializeObject<Hat>(jo.ToString(), SpecifiedSubclassConversion);
                case (int)AbstractItemId.PrimaryWeapon:
                    return JsonConvert.DeserializeObject<PrimaryWeapon>(jo.ToString(), SpecifiedSubclassConversion);
                case (int)AbstractItemId.SecondaryWeapon:
                    return JsonConvert.DeserializeObject<SecondaryWeapon>(jo.ToString(), SpecifiedSubclassConversion);
                case (int)AbstractItemId.Uniform:
                    return JsonConvert.DeserializeObject<Uniform>(jo.ToString(), SpecifiedSubclassConversion);
                default:
                    throw new Exception();
            }
            throw new NotImplementedException();
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // won't be called because CanWrite returns false
        }
    }
}
