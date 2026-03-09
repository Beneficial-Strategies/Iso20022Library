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
/// Set of data specified for the fixing of a non deliverable trade.
/// </summary>
[IsoId("_THtV2Np-Ed-ak6NoX_4Aeg_855669497")]
[DisplayName("Closing Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClosingData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClosingData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClosingData2( System.DateOnly reqTradeDate,System.String reqNotificationIdentification,AmountsAndValueDate1 reqTradeAmounts,AgreedRate1 reqValuationRate,ValuationData2 reqValuationInformation )
    {
        TradeDate = reqTradeDate;
        NotificationIdentification = reqNotificationIdentification;
        TradeAmounts = reqTradeAmounts;
        ValuationRate = reqValuationRate;
        ValuationInformation = reqValuationInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date at which the trading parties have agreed on a valuation rate for a non deliverable trade.
    /// </summary>
    [IsoId("_TH3G0Np-Ed-ak6NoX_4Aeg_855669499")]
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
    /// Refers to the identification of a trade assigned by the trading side of a non deliverable forward trade.
    /// </summary>
    [IsoId("_TH3G0dp-Ed-ak6NoX_4Aeg_863054176")]
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
    [IsoId("_TH3G0tp-Ed-ak6NoX_4Aeg_855669540")]
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
    [IsoId("_TH3G09p-Ed-ak6NoX_4Aeg_863054236")]
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
    [IsoId("_TH3G1Np-Ed-ak6NoX_4Aeg_863054211")]
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
    /// Specifies the amounts traded at the valuation of a non-deliverable trade.
    /// </summary>
    [IsoId("_TH3G1dp-Ed-ak6NoX_4Aeg_863054332")]
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
    /// Rate obtained at valuation time by following the valuation conditions (agreed upon by the trading parties at the opening of the non-deliverable contract).
    /// </summary>
    [IsoId("_TH3G1tp-Ed-ak6NoX_4Aeg_863054297")]
    [DisplayName("Valuation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnRate")]
    #endif
    [IsoXmlTag("ValtnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate1 ValuationRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate1 ValuationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate1 ValuationRate { get; init; } 
    #else
    public AgreedRate1 ValuationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Set of parameters used to calculate the valuation rate to be applied to a non-deliverable agreement.
    /// </summary>
    [IsoId("_TH3G19p-Ed-ak6NoX_4Aeg_863054272")]
    [DisplayName("Valuation Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnInf")]
    #endif
    [IsoXmlTag("ValtnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValuationData2 ValuationInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValuationData2 ValuationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationData2 ValuationInformation { get; init; } 
    #else
    public ValuationData2 ValuationInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
