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
/// Defines the criteria used to search for a report.
/// </summary>
[IsoId("_3b6DFZb6Eee4htziCyV8eA")]
[DisplayName("Report Query Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportQuerySearchCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportQuerySearchCriteria2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportQuerySearchCriteria2( PartyIdentification136 reqPartyIdentification )
    {
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_3pS-0Zb6Eee4htziCyV8eA")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
    /// </summary>
    [IsoId("_3pS-05b6Eee4htziCyV8eA")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalance12? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalance12? Balance { get; init; } 
    #else
    public CashBalance12? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Values of possible reports.
    /// </summary>
    [IsoId("_3pS-1Zb6Eee4htziCyV8eA")]
    [DisplayName("Report Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNm")]
    #endif
    [IsoXmlTag("RptNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? ReportName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportName { get; init; } 
    #else
    public System.String? ReportName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the query message name identifier to which the message refers.
    /// </summary>
    [IsoId("_S1RJ0Fg7Eeiv7OYKCzUSAg")]
    [DisplayName("Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNmId")]
    #endif
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageNameIdentification { get; init; } 
    #else
    public System.String? MessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Report owning party.
    /// </summary>
    [IsoId("_3pS-15b6Eee4htziCyV8eA")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification136 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification136 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136 PartyIdentification { get; init; } 
    #else
    public PartyIdentification136 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Responsible Party of the report owning party.
    /// </summary>
    [IsoId("_3pS-2Zb6Eee4htziCyV8eA")]
    [DisplayName("Responsible Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPtyId")]
    #endif
    [IsoXmlTag("RspnsblPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    #else
    public PartyIdentification136? ResponsiblePartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when the report was created.
    /// </summary>
    [IsoId("_3pS-25b6Eee4htziCyV8eA")]
    [DisplayName("Date Search")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtSch")]
    #endif
    [IsoXmlTag("DtSch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodSearch1Choice_? DateSearch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodSearch1Choice_? DateSearch { get; init; } 
    #else
    public DatePeriodSearch1Choice_? DateSearch { get; set; } 
    #endif
    
    /// <summary>
    /// Time when the (business) event, which triggered the report, was scheduled.
    /// </summary>
    [IsoId("_3pS-3Zb6Eee4htziCyV8eA")]
    [DisplayName("Scheduled Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchdldTm")]
    #endif
    [IsoXmlTag("SchdldTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? ScheduledTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? ScheduledTime { get; init; } 
    #else
    public DateTimePeriod1Choice_? ScheduledTime { get; set; } 
    #endif
    
    /// <summary>
    /// Execution type is executed based on an event driven trigger.
    /// </summary>
    [IsoId("_mEwyoVg9Eeiv7OYKCzUSAg")]
    [DisplayName("Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Evt")]
    #endif
    [IsoXmlTag("Evt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventType1Choice_? Event { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventType1Choice_? Event { get; init; } 
    #else
    public EventType1Choice_? Event { get; set; } 
    #endif
    
    
    #nullable disable
    
}
