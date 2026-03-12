// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction information to be transferred.
/// </summary>
[IsoId("_Y-DEIfwLEeGHDMP28rpT3g_1761080314")]
[DisplayName("Transaction Data")]
public partial record TransactionData1
{
    #nullable enable
    
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_Y-DEIvwLEeGHDMP28rpT3g_237700941")]
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CardBrand { get; init; } 
    
    /// <summary>
    /// Card data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_Y-DEI_wLEeGHDMP28rpT3g_304673772")]
    [DisplayName("Card Data")]
    [IsoXmlTag("CardData")]
    public PlainCardData3? CardData { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_Y-DEJPwLEeGHDMP28rpT3g_362363636")]
    [DisplayName("Point Of Interaction")]
    [IsoXmlTag("PtOfIntractn")]
    public PointOfInteraction1? PointOfInteraction { get; init; } 
    
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_Y-M1IPwLEeGHDMP28rpT3g_-1560928202")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public CardPaymentTransactionDetails8? TransactionDetails { get; init; } 
    
    /// <summary>
    /// PrePaid Account for funds transfer or loading.
    /// </summary>
    [IsoId("_Y-M1IfwLEeGHDMP28rpT3g_769227939")]
    [DisplayName("Pre Paid Account")]
    [IsoXmlTag("PrePdAcct")]
    public CashAccount24? PrePaidAccount { get; init; } 
    
    
    #nullable disable
    
}
