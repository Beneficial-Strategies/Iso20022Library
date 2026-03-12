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
[IsoId("_tluXUeLXEeWFtOV72FbX9w")]
[DisplayName("Eligible Security")]
public partial record EligibleSecurity2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_txLZYeLXEeWFtOV72FbX9w")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_txLZY-LXEeWFtOV72FbX9w")]
    [DisplayName("Collateralisation Currency")]
    [IsoXmlTag("CollstnCcy")]
    public required ActiveOrHistoricCurrencyCode CollateralisationCurrency { get; init; } 
    
    /// <summary>
    /// Identifies the party for which the eligible security is defined.
    /// </summary>
    [IsoId("_txLZZeLXEeWFtOV72FbX9w")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required NCBOrPaymentBank1Choice_ PartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
