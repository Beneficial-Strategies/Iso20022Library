// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction information to be transferred.
/// </summary>
[IsoId("_Y-DEIfwLEeGHDMP28rpT3g_1761080314")]
[DisplayName("Transaction Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_Y-DEIvwLEeGHDMP28rpT3g_237700941")]
    [DisplayName("Card Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardBrnd")]
    #endif
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardBrand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardBrand { get; init; } 
    #else
    public System.String? CardBrand { get; set; } 
    #endif
    
    /// <summary>
    /// Card data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_Y-DEI_wLEeGHDMP28rpT3g_304673772")]
    [DisplayName("Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardData")]
    #endif
    [IsoXmlTag("CardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData3? CardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData3? CardData { get; init; } 
    #else
    public PlainCardData3? CardData { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_Y-DEJPwLEeGHDMP28rpT3g_362363636")]
    [DisplayName("Point Of Interaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtOfIntractn")]
    #endif
    [IsoXmlTag("PtOfIntractn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteraction1? PointOfInteraction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction1? PointOfInteraction { get; init; } 
    #else
    public PointOfInteraction1? PointOfInteraction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_Y-M1IPwLEeGHDMP28rpT3g_-1560928202")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransactionDetails8? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransactionDetails8? TransactionDetails { get; init; } 
    #else
    public CardPaymentTransactionDetails8? TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// PrePaid Account for funds transfer or loading.
    /// </summary>
    [IsoId("_Y-M1IfwLEeGHDMP28rpT3g_769227939")]
    [DisplayName("Pre Paid Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrePdAcct")]
    #endif
    [IsoXmlTag("PrePdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? PrePaidAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? PrePaidAccount { get; init; } 
    #else
    public CashAccount24? PrePaidAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
