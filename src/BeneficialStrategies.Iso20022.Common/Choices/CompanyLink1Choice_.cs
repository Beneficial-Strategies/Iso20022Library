// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the trading party or broker.
    /// </summary>
    [KnownType(typeof(CompanyLink1Choice.Code))]
    [KnownType(typeof(CompanyLink1Choice.Proprietary))]
    [JsonDerivedType(typeof(CompanyLink1Choice.Code), nameof(CompanyLink1Choice.Code))]
    [JsonDerivedType(
        typeof(CompanyLink1Choice.Proprietary),
        nameof(CompanyLink1Choice.Proprietary)
    )]
    [IsoId("_xMOncCCZEeWJd9HF2tO7BA")]
    [DisplayName("Company Link 1 Choice")]
    public abstract record CompanyLink1Choice_ { }
}
