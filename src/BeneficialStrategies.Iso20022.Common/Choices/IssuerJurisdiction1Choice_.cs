// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. 
    /// </summary>
    [KnownType(typeof(IssuerJurisdiction1Choice.CountryCode))]
    [KnownType(typeof(IssuerJurisdiction1Choice.Other))]
    [JsonDerivedType(typeof(IssuerJurisdiction1Choice.CountryCode),nameof(IssuerJurisdiction1Choice.CountryCode))]
    [JsonDerivedType(typeof(IssuerJurisdiction1Choice.Other),nameof(IssuerJurisdiction1Choice.Other))]
    [IsoId("_qFVoIIfXEeu9_PKSQNOmdg")]
    [DisplayName("Issuer Jurisdiction 1 Choice")]
    public abstract partial record IssuerJurisdiction1Choice_
    {
    }
}
