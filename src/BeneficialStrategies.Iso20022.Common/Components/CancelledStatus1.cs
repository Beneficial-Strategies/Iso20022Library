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
/// Status is cancelled.
/// </summary>
[IsoId("_UwnNXNp-Ed-ak6NoX_4Aeg_-1540666967")]
[DisplayName("Cancelled Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelledStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancelledStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelledStatus1( NoReasonCode reqNoReason,CancelledStatusReason1 reqReason,GenericIdentification1 reqDataSourceScheme )
    {
        NoReason = reqNoReason;
        Reason = reqReason;
        DataSourceScheme = reqDataSourceScheme;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_Uww-UNp-Ed-ak6NoX_4Aeg_-1540666948")]
    [DisplayName("No Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoRsn")]
    #endif
    [IsoXmlTag("NoRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NoReasonCode NoReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NoReasonCode NoReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NoReasonCode NoReason { get; init; } 
    #else
    public NoReasonCode NoReason { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for a cancelled status in the report.
    /// </summary>
    [IsoId("_Uww-Udp-Ed-ak6NoX_4Aeg_-1540666611")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatusReason1 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatusReason1 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatusReason1 Reason { get; init; } 
    #else
    public CancelledStatusReason1 Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of a reason for a cancelled status in the report.
    /// </summary>
    [IsoId("_Uww-Utp-Ed-ak6NoX_4Aeg_-1540666906")]
    [DisplayName("Data Source Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSrcSchme")]
    #endif
    [IsoXmlTag("DataSrcSchme")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1 DataSourceScheme { get; init; } 
    #else
    public GenericIdentification1 DataSourceScheme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
