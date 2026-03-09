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
/// Detailed information on statistics per combination of counterparties.
/// </summary>
[IsoId("_MYzuUVfdEeqZr5K1Woax-g")]
[DisplayName("Detailed Statistics Per Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedStatisticsPerCounterparty6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedStatisticsPerCounterparty6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedStatisticsPerCounterparty6( Period2 reqReportingPeriod,CounterpartyData36 reqCounterpartyIdentification,RejectionStatistics3 reqRejectionStatistics )
    {
        ReportingPeriod = reqReportingPeriod;
        CounterpartyIdentification = reqCounterpartyIdentification;
        RejectionStatistics = reqRejectionStatistics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference period for statistics collection.
    /// </summary>
    [IsoId("_MweAYVfdEeqZr5K1Woax-g")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Period2 ReportingPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Period2 ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period2 ReportingPeriod { get; init; } 
    #else
    public Period2 ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_MweAY1fdEeqZr5K1Woax-g")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyData36 CounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyData36 CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData36 CounterpartyIdentification { get; init; } 
    #else
    public CounterpartyData36 CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
    /// </summary>
    [IsoId("_MweAZVfdEeqZr5K1Woax-g")]
    [DisplayName("Rejection Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnSttstcs")]
    #endif
    [IsoXmlTag("RjctnSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionStatistics3 RejectionStatistics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectionStatistics3 RejectionStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionStatistics3 RejectionStatistics { get; init; } 
    #else
    public RejectionStatistics3 RejectionStatistics { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the competent authority which supervises the reporting counterparty.
    /// </summary>
    [IsoId("_MweAZ1fdEeqZr5K1Woax-g")]
    [DisplayName("Competent Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmptntAuthrty")]
    #endif
    [IsoXmlTag("CmptntAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompetentAuthority1? CompetentAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompetentAuthority1? CompetentAuthority { get; init; } 
    #else
    public CompetentAuthority1? CompetentAuthority { get; set; } 
    #endif
    
    
    #nullable disable
    
}
