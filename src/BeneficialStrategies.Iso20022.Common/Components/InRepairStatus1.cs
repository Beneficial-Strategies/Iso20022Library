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
/// Status is in repair.
/// </summary>
[IsoId("_Uuhiptp-Ed-ak6NoX_4Aeg_-794783023")]
[DisplayName("In Repair Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InRepairStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InRepairStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InRepairStatus1( NoReasonCode reqNoReason,InRepairStatusReason1 reqReason,GenericIdentification1 reqDataSourceScheme )
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
    [IsoId("_UurToNp-Ed-ak6NoX_4Aeg_-794782787")]
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
    /// Reason of an in repair status in the report.
    /// </summary>
    [IsoId("_UurTodp-Ed-ak6NoX_4Aeg_-794782710")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InRepairStatusReason1 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InRepairStatusReason1 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InRepairStatusReason1 Reason { get; init; } 
    #else
    public InRepairStatusReason1 Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification for a reason of a specific status in the report.
    /// </summary>
    [IsoId("_UurTotp-Ed-ak6NoX_4Aeg_-794782752")]
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
