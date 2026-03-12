// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_QN5QFtp-Ed-ak6NoX_4Aeg_-1242436209")]
[DisplayName("Intermediary")]
public partial record Intermediary9
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_QN5QF9p-Ed-ak6NoX_4Aeg_-1242436191")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification2Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QN5QGNp-Ed-ak6NoX_4Aeg_-1242436053")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account7? Account { get; init; } 
    
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_QOCaANp-Ed-ak6NoX_4Aeg_-1242436131")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; } 
    
    /// <summary>
    /// Capacity of the party executing an order.
    /// </summary>
    [IsoId("_QOCaAdp-Ed-ak6NoX_4Aeg_1361094241")]
    [DisplayName("Trading Party Capacity")]
    [IsoXmlTag("TradgPtyCpcty")]
    public TradingCapacity2Code? TradingPartyCapacity { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOCaAtp-Ed-ak6NoX_4Aeg_-1242436166")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole2Code? Role { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOCaA9p-Ed-ak6NoX_4Aeg_-1242436149")]
    [DisplayName("Extended Role")]
    [IsoXmlTag("XtndedRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedRole { get; init; } 
    
    
    #nullable disable
    
}
