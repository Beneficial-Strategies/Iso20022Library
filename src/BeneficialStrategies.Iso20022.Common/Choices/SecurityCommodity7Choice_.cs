// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of assets subject of the transaction.
    /// </summary>
    [KnownType(typeof(SecurityCommodity7Choice.Security))]
    [KnownType(typeof(SecurityCommodity7Choice.Commodity))]
    [JsonDerivedType(
        typeof(SecurityCommodity7Choice.Security),
        nameof(SecurityCommodity7Choice.Security)
    )]
    [JsonDerivedType(
        typeof(SecurityCommodity7Choice.Commodity),
        nameof(SecurityCommodity7Choice.Commodity)
    )]
    [IsoId("_UkKfccgyEeuGrNSsxk3B0A")]
    [DisplayName("Security Commodity 7 Choice")]
    public abstract record SecurityCommodity7Choice_ { }
}
