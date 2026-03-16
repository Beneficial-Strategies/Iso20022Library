// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the investor capacity.
    /// </summary>
    [KnownType(typeof(InvestorCapacity3Choice.Code))]
    [KnownType(typeof(InvestorCapacity3Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorCapacity3Choice.Code), nameof(InvestorCapacity3Choice.Code))]
    [JsonDerivedType(
        typeof(InvestorCapacity3Choice.Proprietary),
        nameof(InvestorCapacity3Choice.Proprietary)
    )]
    [IsoId("_AeB1QdokEeC60axPepSq7g_986173971")]
    [DisplayName("Investor Capacity 3 Choice")]
    public abstract record InvestorCapacity3Choice_ { }
}
