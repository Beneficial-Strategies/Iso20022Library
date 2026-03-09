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
/// Provides the money market statistical status report header details.
/// </summary>
[IsoId("_olkndNjLEeSD0e0ybx5L5Q")]
[DisplayName("Money Market Status Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MoneyMarketStatusReportHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MoneyMarketStatusReportHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MoneyMarketStatusReportHeader1( System.String reqReportingAgent,DateTimePeriod1 reqReportingPeriod,StatisticalReportingStatus1Code reqReportStatus )
    {
        ReportingAgent = reqReportingAgent;
        ReportingPeriod = reqReportingPeriod;
        ReportStatus = reqReportStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Agent which is subject to reporting requirements.
    /// </summary>
    [IsoId("_oluYcNjLEeSD0e0ybx5L5Q")]
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
    /// For daily reporting this is the day to which the transaction data in the status message refers (trade date or amendment date if there are corrections).
    /// For periodic reporting this is the first and the last day to which the transaction data in the status message refers (trade date or amendment date in case of corrections).
    /// </summary>
    [IsoId("_oluYctjLEeSD0e0ybx5L5Q")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateTimePeriod1 ReportingPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateTimePeriod1 ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1 ReportingPeriod { get; init; } 
    #else
    public DateTimePeriod1 ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status for the full report.
    /// </summary>
    [IsoId("_oluYcdjLEeSD0e0ybx5L5Q")]
    [DisplayName("Report Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSts")]
    #endif
    [IsoXmlTag("RptSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticalReportingStatus1Code ReportStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticalReportingStatus1Code ReportStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticalReportingStatus1Code ReportStatus { get; init; } 
    #else
    public StatisticalReportingStatus1Code ReportStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_Bqe1sd7HEeSaBeqd_btViQ")]
    [DisplayName("Validation Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnRule")]
    #endif
    [IsoXmlTag("VldtnRule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #else
    public GenericValidationRuleIdentification1? ValidationRule { get; set; } 
    #endif
    
    
    #nullable disable
    
}
