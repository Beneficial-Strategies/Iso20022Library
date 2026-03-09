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
/// Set of data which contains the link to a previously notified option trade.
/// </summary>
[IsoId("_U8r6ddp-Ed-ak6NoX_4Aeg_254982681")]
[DisplayName("Option Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionData2( System.DateOnly reqTradeDate,System.String reqNotificationIdentification,Option3 reqOption )
    {
        TradeDate = reqTradeDate;
        NotificationIdentification = reqNotificationIdentification;
        Option = reqOption;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date at which the trading parties have agreed on an option trade.
    /// </summary>
    [IsoId("_U8r6dtp-Ed-ak6NoX_4Aeg_254982700")]
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
    /// Refers to the identification of a trade assigned by the trading side of a foreign exchange option trade.
    /// </summary>
    [IsoId("_U8r6d9p-Ed-ak6NoX_4Aeg_254982734")]
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
    [IsoId("_U8r6eNp-Ed-ak6NoX_4Aeg_254982716")]
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
    /// Refers to the identification of a previous event in the life of a foreign exchange option trade.
    /// </summary>
    [IsoId("_U8r6edp-Ed-ak6NoX_4Aeg_254982776")]
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
    [IsoId("_U81EYNp-Ed-ak6NoX_4Aeg_254982759")]
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
    /// Set of data defining a foreign exchange option sold.
    /// </summary>
    [IsoId("_U81EYdp-Ed-ak6NoX_4Aeg_254982826")]
    [DisplayName("Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Optn")]
    #endif
    [IsoXmlTag("Optn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Option3 Option { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Option3 Option { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Option3 Option { get; init; } 
    #else
    public Option3 Option { get; set; } 
    #endif
    
    
    #nullable disable
    
}
