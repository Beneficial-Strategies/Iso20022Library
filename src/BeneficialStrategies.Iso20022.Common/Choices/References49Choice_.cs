// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References49Choice.RelatedReference))]
    [KnownType(typeof(References49Choice.OtherReference))]
    [JsonDerivedType(typeof(References49Choice.RelatedReference),nameof(References49Choice.RelatedReference))]
    [JsonDerivedType(typeof(References49Choice.OtherReference),nameof(References49Choice.OtherReference))]
    [IsoId("_dSWYESYtEeW_ZNn8gbfY7Q")]
    [DisplayName("References 49 Choice")]
    public abstract partial record References49Choice_
    {
    }
}
