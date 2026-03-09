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
/// Status is unmatched.
/// </summary>
[IsoId("_U0V2xNp-Ed-ak6NoX_4Aeg_-105274052")]
[DisplayName("Transfer Unmatched Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferUnmatchedStatus
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferUnmatchedStatus instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferUnmatchedStatus( TransferUnmatchedStatusReason1 reqReason,GenericIdentification1 reqDataSourceScheme,NoReasonCode reqNoReason )
    {
        Reason = reqReason;
        DataSourceScheme = reqDataSourceScheme;
        NoReason = reqNoReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for an unmatched status in the report.
    /// </summary>
    [IsoId("_U0V2xdp-Ed-ak6NoX_4Aeg_759138876")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferUnmatchedStatusReason1 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferUnmatchedStatusReason1 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferUnmatchedStatusReason1 Reason { get; init; } 
    #else
    public TransferUnmatchedStatusReason1 Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification for a reason of a specific status in the report.
    /// </summary>
    [IsoId("_U0V2xtp-Ed-ak6NoX_4Aeg_94206093")]
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
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_U0V2x9p-Ed-ak6NoX_4Aeg_72964022")]
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
    
    
    #nullable disable
    
}
