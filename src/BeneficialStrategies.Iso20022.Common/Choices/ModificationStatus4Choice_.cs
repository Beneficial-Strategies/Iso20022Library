// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of modification status.
    /// </summary>
    [KnownType(typeof(ModificationStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(ModificationStatus4Choice.Reason))]
    [JsonDerivedType(
        typeof(ModificationStatus4Choice.NoSpecifiedReason),
        nameof(ModificationStatus4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ModificationStatus4Choice.Reason),
        nameof(ModificationStatus4Choice.Reason)
    )]
    [IsoId("_CdYXgTq3EeWyoP0PbocV1Q")]
    [DisplayName("Modification Status 4 Choice")]
    public abstract record ModificationStatus4Choice_ { }
}
