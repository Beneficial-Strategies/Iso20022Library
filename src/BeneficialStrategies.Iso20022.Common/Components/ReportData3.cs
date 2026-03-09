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
[IsoId("_S3i5sgEcEeCQm6a_G2yO_w_1955726096")]
[DisplayName("Report Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportData3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportData3( System.String reqMessageIdentification,System.DateOnly reqValueDate,System.DateTime reqDateAndTimeStamp,Entry2Code reqType )
    {
        MessageIdentification = reqMessageIdentification;
        ValueDate = reqValueDate;
        DateAndTimeStamp = reqDateAndTimeStamp;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the report as assigned by the sender.
    /// </summary>
    [IsoId("_S3i5swEcEeCQm6a_G2yO_w_1841887030")]
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
    /// Value date for which the pay-in schedule is generated.
    /// </summary>
    [IsoId("_S3i5tAEcEeCQm6a_G2yO_w_958653743")]
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
    [IsoId("_S3i5tQEcEeCQm6a_G2yO_w_844814677")]
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
    /// Type of pay-in schedule.
    /// </summary>
    [IsoId("_S3i5tgEcEeCQm6a_G2yO_w_-1725885432")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Entry2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Entry2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Entry2Code Type { get; init; } 
    #else
    public Entry2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the settlement session to which the report applies. The first session of the day is 1.
    /// </summary>
    [IsoId("_S3i5twEcEeCQm6a_G2yO_w_-952737875")]
    [DisplayName("Settlement Session")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSsn")]
    #endif
    [IsoXmlTag("SttlmSsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SettlementSession { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SettlementSession { get; init; } 
    #else
    public System.UInt64? SettlementSession { get; set; } 
    #endif
    
    
    #nullable disable
    
}
