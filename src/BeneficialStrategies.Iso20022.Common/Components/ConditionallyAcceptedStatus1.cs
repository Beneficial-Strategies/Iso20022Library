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
/// Status that is accepted under certain conditions.
/// </summary>
[IsoId("_UyQMGtp-Ed-ak6NoX_4Aeg_94624297")]
[DisplayName("Conditionally Accepted Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConditionallyAcceptedStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ConditionallyAcceptedStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ConditionallyAcceptedStatus1( NoReasonCode reqNoReason,ConditionallyAcceptedStatusReason1 reqReason,GenericIdentification1 reqDataSourceScheme )
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
    [IsoId("_UyZ9ENp-Ed-ak6NoX_4Aeg_94624315")]
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
    /// Reason for a conditionally accepted status in the report.
    /// </summary>
    [IsoId("_UyZ9Edp-Ed-ak6NoX_4Aeg_95544442")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConditionallyAcceptedStatusReason1 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConditionallyAcceptedStatusReason1 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConditionallyAcceptedStatusReason1 Reason { get; init; } 
    #else
    public ConditionallyAcceptedStatusReason1 Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of a reason for a conditionally accepted status in the report.
    /// </summary>
    [IsoId("_UyZ9Etp-Ed-ak6NoX_4Aeg_95544382")]
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
