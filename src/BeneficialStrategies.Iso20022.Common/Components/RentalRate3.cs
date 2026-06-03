// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle rental rate.
/// </summary>
[IsoId("_8UHSIXnwEfCmC4yYaU27Kg")]
[DisplayName("Rental Rate3")]
public record RentalRate3
{
    /// <summary>
    /// Unit of measure used to compute the rental rate.
    /// </summary>
    [IsoId("_8W5gYXnwEfCmC4yYaU27Kg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public PeriodUnit5Code? Period { get; init; }

    /// <summary>
    /// Rate applied to the vehicle rental for the specified period.
    /// </summary>
    [IsoId("_8W5gZXnwEfCmC4yYaU27Kg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public ImpliedCurrencyAndAmount? Rate { get; init; }

    /// <summary>
    /// Duration of the period for which the rental rate is calculated.
    /// </summary>
    [IsoId("_8W5gZ3nwEfCmC4yYaU27Kg")]
    [DisplayName("Period Count")]
    [IsoXmlTag("PrdCnt")]
    public IsoMax4NumericText? PeriodCount { get; init; }
}
