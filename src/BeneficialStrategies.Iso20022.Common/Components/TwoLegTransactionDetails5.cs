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
/// Specifies the details of the first leg in a two leg transaction process.
/// </summary>
[IsoId("_x7vQEQhKEe2fOITqoTnSLQ")]
[DisplayName("Two Leg Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TwoLegTransactionDetails5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_yM4DYQhKEe2fOITqoTnSLQ")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate8Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate8Choice_? TradeDate { get; init; } 
    #else
    public TradeDate8Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the reference assigned in the first leg of the transaction.
    /// </summary>
    [IsoId("_yM4DYwhKEe2fOITqoTnSLQ")]
    [DisplayName("Opening Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngLegId")]
    #endif
    [IsoXmlTag("OpngLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OpeningLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OpeningLegIdentification { get; init; } 
    #else
    public System.String? OpeningLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_yM4DZQhKEe2fOITqoTnSLQ")]
    [DisplayName("Closing Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgLegId")]
    #endif
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClosingLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosingLegIdentification { get; init; } 
    #else
    public System.String? ClosingLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_yM4DZwhKEe2fOITqoTnSLQ")]
    [DisplayName("Gross Trade Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssTradAmt")]
    #endif
    [IsoXmlTag("GrssTradAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? GrossTradeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? GrossTradeAmount { get; init; } 
    #else
    public AmountAndDirection29? GrossTradeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies other amounts pertaining to the transaction.
    /// </summary>
    [IsoId("_yM4DaQhKEe2fOITqoTnSLQ")]
    [DisplayName("Other Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmts")]
    #endif
    [IsoXmlTag("OthrAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmounts16? OtherAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmounts16? OtherAmounts { get; init; } 
    #else
    public OtherAmounts16? OtherAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_yM4DawhKEe2fOITqoTnSLQ")]
    [DisplayName("Second Leg Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLegNrrtv")]
    #endif
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SecondLegNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondLegNarrative { get; init; } 
    #else
    public System.String? SecondLegNarrative { get; set; } 
    #endif
    
    /// <summary>
    /// Negotiated fixed price of the security to buy it back.
    /// </summary>
    [IsoId("_yM4DbQhKEe2fOITqoTnSLQ")]
    [DisplayName("End Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndPric")]
    #endif
    [IsoXmlTag("EndPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? EndPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? EndPrice { get; init; } 
    #else
    public Price14? EndPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_yM4DbwhKEe2fOITqoTnSLQ")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosingDate4Choice_? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingDate4Choice_? ClosingDate { get; init; } 
    #else
    public ClosingDate4Choice_? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.
    /// </summary>
    [IsoId("_yM4DdwhKEe2fOITqoTnSLQ")]
    [DisplayName("Closing Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgSttlmAmt")]
    #endif
    [IsoXmlTag("ClsgSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection5? ClosingSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5? ClosingSettlementAmount { get; init; } 
    #else
    public AmountAndDirection5? ClosingSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Processing date of the trading session.
    /// </summary>
    [IsoId("_yM4DeQhKEe2fOITqoTnSLQ")]
    [DisplayName("Processing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgDt")]
    #endif
    [IsoXmlTag("PrcgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate7Choice_? ProcessingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate7Choice_? ProcessingDate { get; init; } 
    #else
    public TradeDate7Choice_? ProcessingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the second leg transaction.
    /// </summary>
    [IsoId("_yM4DewhKEe2fOITqoTnSLQ")]
    [DisplayName("Two Leg Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwoLegTxTp")]
    #endif
    [IsoXmlTag("TwoLegTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TwoLegTransactionType4Choice_? TwoLegTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TwoLegTransactionType4Choice_? TwoLegTransactionType { get; init; } 
    #else
    public TwoLegTransactionType4Choice_? TwoLegTransactionType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
