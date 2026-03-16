// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Issuer Or Investor2Choice.
    /// </summary>
    [KnownType(typeof(IssuerOrInvestor2Choice.InvestorCSD))]
    [KnownType(typeof(IssuerOrInvestor2Choice.IssuerCSD))]
    [JsonDerivedType(
        typeof(IssuerOrInvestor2Choice.InvestorCSD),
        nameof(IssuerOrInvestor2Choice.InvestorCSD)
    )]
    [JsonDerivedType(
        typeof(IssuerOrInvestor2Choice.IssuerCSD),
        nameof(IssuerOrInvestor2Choice.IssuerCSD)
    )]
    [IsoId("_yVpDgWc-EemvNLufWGIVOQ")]
    [DisplayName("Issuer Or Investor2Choice")]
    public abstract record IssuerOrInvestor2Choice_ { }
}
