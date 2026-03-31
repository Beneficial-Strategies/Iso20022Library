// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return provided by a financial instrument.
/// </summary>
[IsoId("_1qNR4Wp7EemmaZLSPtWX5A")]
[DisplayName("Yield Calculation")]
public record YieldCalculation6
{
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    [IsoId("_12n9QWp7EemmaZLSPtWX5A")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Value { get; init; }

    /// <summary>
    /// Specifies the type of calculation.
    /// </summary>
    [IsoId("_12n9SWp7EemmaZLSPtWX5A")]
    [DisplayName("Calculation Type")]
    [IsoXmlTag("ClctnTp")]
    public CalculationType3Choice_? CalculationType { get; init; }

    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    [IsoId("_12n9UWp7EemmaZLSPtWX5A")]
    [DisplayName("Redemption Price")]
    [IsoXmlTag("RedPric")]
    public Price8? RedemptionPrice { get; init; }

    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    [IsoId("_12n9X2p7EemmaZLSPtWX5A")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    [IsoId("_12n9Z2p7EemmaZLSPtWX5A")]
    [DisplayName("Value Period")]
    [IsoXmlTag("ValPrd")]
    public required DateTimePeriod1Choice_ ValuePeriod { get; init; }

    /// <summary>
    /// Clarifies yield irregularities associated with date, for example when it falls on a non-business day.
    /// </summary>
    [IsoId("_12n9b2p7EemmaZLSPtWX5A")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CalculationDate { get; init; }
}
