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
[IsoId("_eFO8kQeCEe2fOITqoTnSLQ")]
[DisplayName("Yield Calculation")]
public partial record YieldCalculation7
{
    #nullable enable
    
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    [IsoId("_eXkCsQeCEe2fOITqoTnSLQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Value { get; init; } 
    
    /// <summary>
    /// Specifies the type of calculation.
    /// </summary>
    [IsoId("_eXkCuQeCEe2fOITqoTnSLQ")]
    [DisplayName("Calculation Type")]
    [IsoXmlTag("ClctnTp")]
    public required CalculationType1Code CalculationType { get; init; } 
    
    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    [IsoId("_eXkCwQeCEe2fOITqoTnSLQ")]
    [DisplayName("Redemption Price")]
    [IsoXmlTag("RedPric")]
    public Price14? RedemptionPrice { get; init; } 
    
    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    [IsoId("_eXkCzweCEe2fOITqoTnSLQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    [IsoId("_eXkC1weCEe2fOITqoTnSLQ")]
    [DisplayName("Value Period")]
    [IsoXmlTag("ValPrd")]
    public DateTimePeriod1Choice_? ValuePeriod { get; init; } 
    
    /// <summary>
    /// Included as needed to clarify yield irregularities associated with date, e.g. when it falls on a non-business day.
    /// </summary>
    [IsoId("_eXkC3weCEe2fOITqoTnSLQ")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; } 
    
    
    #nullable disable
    
}
