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
/// Date and time query criteria.
/// </summary>
[IsoId("_aPgSUdGREeaQk737TH1Fzw")]
[DisplayName("Trade Date Time Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeDateTimeQueryCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the reporting date and full hour that transaction was reported.
    /// </summary>
    [IsoId("_aYTB8dGREeaQk737TH1Fzw")]
    [DisplayName("Reporting Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDtTm")]
    #endif
    [IsoXmlTag("RptgDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1? ReportingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1? ReportingDateTime { get; init; } 
    #else
    public DateTimePeriod1? ReportingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and full hour the trade was executed.
    /// </summary>
    [IsoId("_aYTB89GREeaQk737TH1Fzw")]
    [DisplayName("Execution Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnDtTm")]
    #endif
    [IsoXmlTag("ExctnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1? ExecutionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1? ExecutionDateTime { get; init; } 
    #else
    public DateTimePeriod1? ExecutionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date when the trade was matured.
    /// </summary>
    [IsoId("_aYTB9dGREeaQk737TH1Fzw")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrBlankQuery2Choice_? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrBlankQuery2Choice_? MaturityDate { get; init; } 
    #else
    public DateOrBlankQuery2Choice_? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date when the trade was terminated.
    /// </summary>
    [IsoId("_aYTB99GREeaQk737TH1Fzw")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrBlankQuery2Choice_? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrBlankQuery2Choice_? TerminationDate { get; init; } 
    #else
    public DateOrBlankQuery2Choice_? TerminationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
