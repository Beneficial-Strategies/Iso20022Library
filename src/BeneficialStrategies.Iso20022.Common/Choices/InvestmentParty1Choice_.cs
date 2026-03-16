// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of the investment party.
    /// </summary>
    [KnownType(typeof(InvestmentParty1Choice.Person))]
    [KnownType(typeof(InvestmentParty1Choice.Algorithm))]
    [JsonDerivedType(typeof(InvestmentParty1Choice.Person), nameof(InvestmentParty1Choice.Person))]
    [JsonDerivedType(
        typeof(InvestmentParty1Choice.Algorithm),
        nameof(InvestmentParty1Choice.Algorithm)
    )]
    [IsoId("_yM5zQenQEeSsIMG7XCyDQw")]
    [DisplayName("Investment Party 1 Choice")]
    public abstract record InvestmentParty1Choice_ { }
}
