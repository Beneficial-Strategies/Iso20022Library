// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between an encrypted key value and TR-related data.</summary>
    [KnownType(typeof(KeyValue3Choice.EncryptedKeyValue))]
    [JsonDerivedType(typeof(KeyValue3Choice.EncryptedKeyValue), nameof(KeyValue3Choice.EncryptedKeyValue))]
    [KnownType(typeof(KeyValue3Choice.TRRelatedData))]
    [JsonDerivedType(typeof(KeyValue3Choice.TRRelatedData), nameof(KeyValue3Choice.TRRelatedData))]
    [IsoId("_PYTUscPzEfCTf8R2j0RpdQ")]
    [DisplayName("Key Value 3 Choice")]
    public abstract record KeyValue3Choice_ { }
}
