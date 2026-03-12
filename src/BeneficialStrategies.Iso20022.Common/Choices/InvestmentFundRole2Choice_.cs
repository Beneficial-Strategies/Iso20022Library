// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a Role.
    /// </summary>
    [KnownType(typeof(InvestmentFundRole2Choice.Code))]
    [KnownType(typeof(InvestmentFundRole2Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestmentFundRole2Choice.Code),nameof(InvestmentFundRole2Choice.Code))]
    [JsonDerivedType(typeof(InvestmentFundRole2Choice.Proprietary),nameof(InvestmentFundRole2Choice.Proprietary))]
    [IsoId("_cdaGUDhcEeaRwdGFv45qTQ")]
    [DisplayName("Investment Fund Role 2 Choice")]
    public abstract partial record InvestmentFundRole2Choice_
    {
    }
}
