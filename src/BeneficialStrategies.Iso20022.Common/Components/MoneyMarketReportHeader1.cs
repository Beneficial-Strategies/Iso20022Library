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
/// Provides the money market statistical report instrument related header details.
/// </summary>
[IsoId("_MVvycJfiEeSfnc-VXAEapg")]
[DisplayName("Money Market Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MoneyMarketReportHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MoneyMarketReportHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MoneyMarketReportHeader1( System.String reqReportingAgent,DateTimePeriod1 reqReferencePeriod )
    {
        ReportingAgent = reqReportingAgent;
        ReferencePeriod = reqReferencePeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Agent which is subject to reporting requirements.
    /// </summary>
    [IsoId("_ziweIJfaEeS92bWS8Fjfig")]
    [DisplayName("Reporting Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgAgt")]
    #endif
    [IsoXmlTag("RptgAgt")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier ReportingAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReportingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReportingAgent { get; init; } 
    #else
    public System.String ReportingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Beginning and ending date-time to which the transaction data refers (trade date in case of new transactions and date of amendment in case of revisions).
    /// </summary>
    [IsoId("_WRwIkZfiEeSfnc-VXAEapg")]
    [DisplayName("Reference Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPrd")]
    #endif
    [IsoXmlTag("RefPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateTimePeriod1 ReferencePeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateTimePeriod1 ReferencePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1 ReferencePeriod { get; init; } 
    #else
    public DateTimePeriod1 ReferencePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
