// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References64Choice.RelatedReference))]
    [KnownType(typeof(References64Choice.OtherReference))]
    [JsonDerivedType(typeof(References64Choice.RelatedReference),nameof(References64Choice.RelatedReference))]
    [JsonDerivedType(typeof(References64Choice.OtherReference),nameof(References64Choice.OtherReference))]
    [IsoId("_5f_BEWpYEeipaMTLlhaKMQ")]
    [DisplayName("References 64 Choice")]
    public abstract partial record References64Choice_
    {
    }
}
