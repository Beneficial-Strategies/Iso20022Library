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
/// Numerical representation of the nett increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
/// </summary>
[IsoId("_tziaQTqeEeKqTf3MbquCbA")]
[DisplayName("Report Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportData5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportData5( System.String reqMessageIdentification,System.DateOnly reqValueDate,System.DateTime reqDateAndTimeStamp,CallIn1Code reqType )
    {
        MessageIdentification = reqMessageIdentification;
        ValueDate = reqValueDate;
        DateAndTimeStamp = reqDateAndTimeStamp;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the report assigned by the central system.
    /// </summary>
    [IsoId("_t_XPwTqeEeKqTf3MbquCbA")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the amount(s) requested must be settled.
    /// </summary>
    [IsoId("_t_XPxTqeEeKqTf3MbquCbA")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time on which the report is generated. The offset with UTC may also be specified.
    /// </summary>
    [IsoId("_t_XPyTqeEeKqTf3MbquCbA")]
    [DisplayName("Date And Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndTmStmp")]
    #endif
    [IsoXmlTag("DtAndTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DateAndTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DateAndTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DateAndTimeStamp { get; init; } 
    #else
    public System.DateTime DateAndTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the Pay In Call.
    /// </summary>
    [IsoId("_t_XPzTqeEeKqTf3MbquCbA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CallIn1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CallIn1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CallIn1Code Type { get; init; } 
    #else
    public CallIn1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount requested.
    /// </summary>
    [IsoId("_t_XP0TqeEeKqTf3MbquCbA")]
    [DisplayName("Pay In Call Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PayInCallAmt")]
    #endif
    [IsoXmlTag("PayInCallAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PayInCallItem? PayInCallAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PayInCallItem? PayInCallAmount { get; init; } 
    #else
    public PayInCallItem? PayInCallAmount { get; set; } 
    #endif
    
    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_wIyaaTqeEeKqTf3MbquCbA")]
    [DisplayName("Settlement Session Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSsnIdr")]
    #endif
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementSessionIdentifier { get; init; } 
    #else
    public System.String? SettlementSessionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the requested amount in multiple currencies.
    /// </summary>
    [IsoId("_t_XP1TqeEeKqTf3MbquCbA")]
    [DisplayName("Account Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctVal")]
    #endif
    [IsoXmlTag("AcctVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Value? AccountValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Value? AccountValue { get; init; } 
    #else
    public Value? AccountValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
