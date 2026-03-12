// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References61Choice.RelatedReference))]
    [KnownType(typeof(References61Choice.OtherReference))]
    [JsonDerivedType(typeof(References61Choice.RelatedReference),nameof(References61Choice.RelatedReference))]
    [JsonDerivedType(typeof(References61Choice.OtherReference),nameof(References61Choice.OtherReference))]
    [IsoId("_kTej8UHOEeazV4RAqPV71g")]
    [DisplayName("References 61 Choice")]
    public abstract partial record References61Choice_
    {
    }
}
