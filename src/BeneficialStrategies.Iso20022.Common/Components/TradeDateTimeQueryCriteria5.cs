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
[IsoId("_np2jIWE3Ee2S65ml6YCOtA")]
[DisplayName("Trade Date Time Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeDateTimeQueryCriteria5
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
    [IsoId("_nrlBc2E3Ee2S65ml6YCOtA")]
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
    [IsoId("_nrlBdWE3Ee2S65ml6YCOtA")]
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
    [IsoId("_nrlBd2E3Ee2S65ml6YCOtA")]
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
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_nrlBeWE3Ee2S65ml6YCOtA")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriod1? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod1? EffectiveDate { get; init; } 
    #else
    public DatePeriod1? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the valuation.
    /// </summary>
    [IsoId("_nrlBe2E3Ee2S65ml6YCOtA")]
    [DisplayName("Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtTm")]
    #endif
    [IsoXmlTag("ValtnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1? ValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1? ValuationDateTime { get; init; } 
    #else
    public DateTimePeriod1? ValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date when the trade was terminated.
    /// </summary>
    [IsoId("_nrlBfWE3Ee2S65ml6YCOtA")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrBlankQuery2Choice_? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrBlankQuery2Choice_? ExpirationDate { get; init; } 
    #else
    public DateOrBlankQuery2Choice_? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the effective date of the early termination of the reported derivative transaction.
    /// </summary>
    [IsoId("_nrlBf2E3Ee2S65ml6YCOtA")]
    [DisplayName("Early Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyTermntnDt")]
    #endif
    [IsoXmlTag("EarlyTermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriod1? EarlyTerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod1? EarlyTerminationDate { get; init; } 
    #else
    public DatePeriod1? EarlyTerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the collateral time stamp range.
    /// </summary>
    [IsoId("_p7LQEGE4Ee2S65ml6YCOtA")]
    [DisplayName("Collateral Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTmStmp")]
    #endif
    [IsoXmlTag("CollTmStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimeOrBlankQuery1Choice_? CollateralTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimeOrBlankQuery1Choice_? CollateralTimeStamp { get; init; } 
    #else
    public DateTimeOrBlankQuery1Choice_? CollateralTimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
