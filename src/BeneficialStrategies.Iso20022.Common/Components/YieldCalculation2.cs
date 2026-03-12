// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return provided by a financial instrument.
/// </summary>
[IsoId("_oLtAMNorEeCWg-hsBVGrDA_726632043")]
[DisplayName("Yield Calculation")]
public partial record YieldCalculation2
{
    #nullable enable
    
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    [IsoId("_oLtAMdorEeCWg-hsBVGrDA_612792977")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Value { get; init; } 
    
    /// <summary>
    /// Specifies the type of calculation.
    /// </summary>
    [IsoId("_oL2KINorEeCWg-hsBVGrDA_-270440310")]
    [DisplayName("Calculation Type")]
    [IsoXmlTag("ClctnTp")]
    public required CalculationType1Code CalculationType { get; init; } 
    
    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    [IsoId("_oL2KIdorEeCWg-hsBVGrDA_1339987811")]
    [DisplayName("Redemption Price")]
    [IsoXmlTag("RedPric")]
    public Price4? RedemptionPrice { get; init; } 
    
    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    [IsoId("_oL2KItorEeCWg-hsBVGrDA_342915458")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    [IsoId("_oL2KI9orEeCWg-hsBVGrDA_229076392")]
    [DisplayName("Value Period")]
    [IsoXmlTag("ValPrd")]
    public DateTimePeriodChoice_? ValuePeriod { get; init; } 
    
    /// <summary>
    /// Included as needed to clarify yield irregularities associated with date, e.g. when it falls on a non-business day.
    /// </summary>
    [IsoId("_oL2KJNorEeCWg-hsBVGrDA_-654156895")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; } 
    
    
    #nullable disable
    
}
