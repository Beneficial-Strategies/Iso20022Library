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
/// Status is rejected.
/// </summary>
[IsoId("_U3BXUtp-Ed-ak6NoX_4Aeg_1285193408")]
[DisplayName("Rejected Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectedStatus4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectedStatus4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectedStatus4( RejectedStatusReason4 reqReason,GenericIdentification1 reqDataSourceScheme )
    {
        Reason = reqReason;
        DataSourceScheme = reqDataSourceScheme;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for a rejected status.
    /// </summary>
    [IsoId("_U3BXU9p-Ed-ak6NoX_4Aeg_1285193486")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatusReason4 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatusReason4 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatusReason4 Reason { get; init; } 
    #else
    public RejectedStatusReason4 Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification for a reason of a rejected status in the report.
    /// </summary>
    [IsoId("_U3BXVNp-Ed-ak6NoX_4Aeg_1285193451")]
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
