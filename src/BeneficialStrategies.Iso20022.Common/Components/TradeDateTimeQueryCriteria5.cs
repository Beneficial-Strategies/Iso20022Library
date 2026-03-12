// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and time query criteria.
/// </summary>
[IsoId("_np2jIWE3Ee2S65ml6YCOtA")]
[DisplayName("Trade Date Time Query Criteria")]
public partial record TradeDateTimeQueryCriteria5
{
    #nullable enable
    
    /// <summary>
    /// Indicates the reporting date and full hour that transaction was reported.
    /// </summary>
    [IsoId("_nrlBc2E3Ee2S65ml6YCOtA")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    public DateTimePeriod1? ReportingDateTime { get; init; } 
    
    /// <summary>
    /// Indicates the date and full hour the trade was executed.
    /// </summary>
    [IsoId("_nrlBdWE3Ee2S65ml6YCOtA")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    public DateTimePeriod1? ExecutionDateTime { get; init; } 
    
    /// <summary>
    /// Indicates the date when the trade was matured.
    /// </summary>
    [IsoId("_nrlBd2E3Ee2S65ml6YCOtA")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateOrBlankQuery2Choice_? MaturityDate { get; init; } 
    
    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_nrlBeWE3Ee2S65ml6YCOtA")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DatePeriod1? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date and time of the valuation.
    /// </summary>
    [IsoId("_nrlBe2E3Ee2S65ml6YCOtA")]
    [DisplayName("Valuation Date Time")]
    [IsoXmlTag("ValtnDtTm")]
    public DateTimePeriod1? ValuationDateTime { get; init; } 
    
    /// <summary>
    /// Indicates the date when the trade was terminated.
    /// </summary>
    [IsoId("_nrlBfWE3Ee2S65ml6YCOtA")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public DateOrBlankQuery2Choice_? ExpirationDate { get; init; } 
    
    /// <summary>
    /// Indicates the effective date of the early termination of the reported derivative transaction.
    /// </summary>
    [IsoId("_nrlBf2E3Ee2S65ml6YCOtA")]
    [DisplayName("Early Termination Date")]
    [IsoXmlTag("EarlyTermntnDt")]
    public DatePeriod1? EarlyTerminationDate { get; init; } 
    
    /// <summary>
    /// Indicates the collateral time stamp range.
    /// </summary>
    [IsoId("_p7LQEGE4Ee2S65ml6YCOtA")]
    [DisplayName("Collateral Time Stamp")]
    [IsoXmlTag("CollTmStmp")]
    public DateTimeOrBlankQuery1Choice_? CollateralTimeStamp { get; init; } 
    
    
    #nullable disable
    
}
