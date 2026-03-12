// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element containing the key information.
    /// </summary>
    [KnownType(typeof(KeyChoiceValue2.EncryptedKeyValue))]
    [KnownType(typeof(KeyChoiceValue2.TRRelatedData))]
    [JsonDerivedType(typeof(KeyChoiceValue2.EncryptedKeyValue),nameof(KeyChoiceValue2.EncryptedKeyValue))]
    [JsonDerivedType(typeof(KeyChoiceValue2.TRRelatedData),nameof(KeyChoiceValue2.TRRelatedData))]
    [IsoId("_Fav_cbTqEeeQy4o2AayYHg")]
    [DisplayName("Key Choice Value")]
    public abstract partial record KeyChoiceValue2_
    {
    }
}
