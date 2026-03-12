// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the eligible securities as defined in the collateral reference data.
/// </summary>
[IsoId("_jARPJO5NEeCisYr99QEiWA_-82514142")]
[DisplayName("Eligible Security")]
public partial record EligibleSecurity1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_jAaZEO5NEeCisYr99QEiWA_1441162586")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public required IsoISINIdentifier SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_jAaZEe5NEeCisYr99QEiWA_-1516085313")]
    [DisplayName("Collateralisation Currency")]
    [IsoXmlTag("CollstnCcy")]
    public required ActiveOrHistoricCurrencyCode CollateralisationCurrency { get; init; } 
    
    /// <summary>
    /// Identifies the party for which the eligible security is defined.
    /// </summary>
    [IsoId("_jAaZEu5NEeCisYr99QEiWA_-423808340")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required NCBOrPaymentBank1Choice_ PartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
