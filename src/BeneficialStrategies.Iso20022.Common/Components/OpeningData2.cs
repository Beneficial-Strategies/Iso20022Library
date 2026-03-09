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
/// List of elements which specify the opening of a non deliverable trade.
/// </summary>
[IsoId("_U8POidp-Ed-ak6NoX_4Aeg_328638139")]
[DisplayName("Opening Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OpeningData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OpeningData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OpeningData2( System.DateOnly reqTradeDate,System.String reqNotificationIdentification,AmountsAndValueDate1 reqTradeAmounts,AgreedRate1 reqAgreedRate,NonDeliverableForwardValuationConditions2 reqValuationConditions )
    {
        TradeDate = reqTradeDate;
        NotificationIdentification = reqNotificationIdentification;
        TradeAmounts = reqTradeAmounts;
        AgreedRate = reqAgreedRate;
        ValuationConditions = reqValuationConditions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date at which the trading parties execute a treasury trade.
    /// </summary>
    [IsoId("_U8POitp-Ed-ak6NoX_4Aeg_328638141")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TradeDate { get; init; } 
    #else
    public System.DateOnly TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Refers to the identification of a notification assigned by the trading side.
    /// </summary>
    [IsoId("_U8Y_gNp-Ed-ak6NoX_4Aeg_328638191")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text NotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NotificationIdentification { get; init; } 
    #else
    public System.String NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference common to the parties of a trade.
    /// </summary>
    [IsoId("_U8Y_gdp-Ed-ak6NoX_4Aeg_328638156")]
    [DisplayName("Common Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonRef")]
    #endif
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CommonReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonReference { get; init; } 
    #else
    public System.String? CommonReference { get; set; } 
    #endif
    
    /// <summary>
    /// Refers to the identification of a previous event in the life of a non deliverable forward trade.
    /// </summary>
    [IsoId("_U8Y_gtp-Ed-ak6NoX_4Aeg_328638426")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedReference { get; init; } 
    #else
    public System.String? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_U8Y_g9p-Ed-ak6NoX_4Aeg_328638451")]
    [DisplayName("Amend Or Cancel Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdOrCclRsn")]
    #endif
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmendOrCancelReason { get; init; } 
    #else
    public System.String? AmendOrCancelReason { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amounts of the non deliverable trade which is reported.
    /// </summary>
    [IsoId("_U8Y_hNp-Ed-ak6NoX_4Aeg_328638532")]
    [DisplayName("Trade Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAmts")]
    #endif
    [IsoXmlTag("TradAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountsAndValueDate1 TradeAmounts { get; init; } 
    #else
    public AmountsAndValueDate1 TradeAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate between two currencies. The rate is agreed by the trading parties during the negotiation process.
    /// </summary>
    [IsoId("_U8Y_hdp-Ed-ak6NoX_4Aeg_328638564")]
    [DisplayName("Agreed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdRate")]
    #endif
    [IsoXmlTag("AgrdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate1 AgreedRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate1 AgreedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate1 AgreedRate { get; init; } 
    #else
    public AgreedRate1 AgreedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Set of parameters used to calculate the valuation rate to be applied to a non-deliverable agreement.
    /// </summary>
    [IsoId("_U8Y_htp-Ed-ak6NoX_4Aeg_328638582")]
    [DisplayName("Valuation Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnConds")]
    #endif
    [IsoXmlTag("ValtnConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonDeliverableForwardValuationConditions2 ValuationConditions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonDeliverableForwardValuationConditions2 ValuationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonDeliverableForwardValuationConditions2 ValuationConditions { get; init; } 
    #else
    public NonDeliverableForwardValuationConditions2 ValuationConditions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
