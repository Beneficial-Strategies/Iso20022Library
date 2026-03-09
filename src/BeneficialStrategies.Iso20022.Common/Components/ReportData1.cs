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
/// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
/// </summary>
[IsoId("_SXbvdtp-Ed-ak6NoX_4Aeg_-759204181")]
[DisplayName("Report Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportData1( System.String reqMessageIdentification,System.DateOnly reqValueDate,System.DateTime reqDateAndTimeStamp,CallIn1Code reqType )
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
    [IsoId("_SXbvd9p-Ed-ak6NoX_4Aeg_-759204120")]
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
    [IsoId("_SXk5YNp-Ed-ak6NoX_4Aeg_628613877")]
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
    [IsoId("_SXk5Ydp-Ed-ak6NoX_4Aeg_-759204151")]
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
    [IsoId("_SXk5Ytp-Ed-ak6NoX_4Aeg_-759204059")]
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
    [IsoId("_SXk5Y9p-Ed-ak6NoX_4Aeg_1451930490")]
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
    /// Specifies the requested amount in multiple currencies.
    /// </summary>
    [IsoId("_SXk5ZNp-Ed-ak6NoX_4Aeg_-2100983347")]
    [DisplayName("Alternate Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnVal")]
    #endif
    [IsoXmlTag("AltrnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Value? AlternateValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Value? AlternateValue { get; init; } 
    #else
    public Value? AlternateValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
