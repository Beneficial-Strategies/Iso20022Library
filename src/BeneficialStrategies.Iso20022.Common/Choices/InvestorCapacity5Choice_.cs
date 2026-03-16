// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the investor capacity.
    /// </summary>
    [KnownType(typeof(InvestorCapacity5Choice.Code))]
    [KnownType(typeof(InvestorCapacity5Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorCapacity5Choice.Code), nameof(InvestorCapacity5Choice.Code))]
    [JsonDerivedType(
        typeof(InvestorCapacity5Choice.Proprietary),
        nameof(InvestorCapacity5Choice.Proprietary)
    )]
    [IsoId("_5mtMY5NLEeWGlc8L7oPDIg")]
    [DisplayName("Investor Capacity 5 Choice")]
    public abstract record InvestorCapacity5Choice_ { }
}
