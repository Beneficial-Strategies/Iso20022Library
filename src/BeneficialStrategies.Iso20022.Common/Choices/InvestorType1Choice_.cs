// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the investor type.
    /// </summary>
    [KnownType(typeof(InvestorType1Choice.Code))]
    [KnownType(typeof(InvestorType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorType1Choice.Code), nameof(InvestorType1Choice.Code))]
    [JsonDerivedType(
        typeof(InvestorType1Choice.Proprietary),
        nameof(InvestorType1Choice.Proprietary)
    )]
    [IsoId("_7Z_KcIzxEemXJvzC2Wyt1g")]
    [DisplayName("Investor Type 1 Choice")]
    public abstract record InvestorType1Choice_ { }
}
