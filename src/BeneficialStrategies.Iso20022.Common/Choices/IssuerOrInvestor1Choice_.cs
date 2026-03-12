// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines how the CSD is linked to the security.
    /// </summary>
    [KnownType(typeof(IssuerOrInvestor1Choice.IssuerCSD))]
    [KnownType(typeof(IssuerOrInvestor1Choice.InvestorCSD))]
    [JsonDerivedType(typeof(IssuerOrInvestor1Choice.IssuerCSD),nameof(IssuerOrInvestor1Choice.IssuerCSD))]
    [JsonDerivedType(typeof(IssuerOrInvestor1Choice.InvestorCSD),nameof(IssuerOrInvestor1Choice.InvestorCSD))]
    [IsoId("_hh_UoWliEeGaMcKyqKNRfQ_1655812261")]
    [DisplayName("Issuer Or Investor 1 Choice")]
    public abstract partial record IssuerOrInvestor1Choice_
    {
    }
}
