// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rental Details3.
/// </summary>
[IsoId("_e2J2gXTkEe6h-4AZRg9sVg")]
[DisplayName("Rental Details3")]
public record RentalDetails3
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Max70Text? Identification { get; init; }

    /// <summary>
    /// Date Time.
    /// </summary>
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public ISODateTime? DateTime { get; init; }

    /// <summary>
    /// Start.
    /// </summary>
    [DisplayName("Start")]
    [IsoXmlTag("Start")]
    public ServiceStartEnd3? Start { get; init; }

    /// <summary>
    /// Return.
    /// </summary>
    [DisplayName("Return")]
    [IsoXmlTag("Rtr")]
    public ServiceStartEnd3? Return { get; init; }

    /// <summary>
    /// Time Period.
    /// </summary>
    [DisplayName("Time Period")]
    [IsoXmlTag("TmPrd")]
    public ValueList<PeriodUnit2Code> TimePeriod { get; init; } = [];

    /// <summary>
    /// Time Period Unit.
    /// </summary>
    [DisplayName("Time Period Unit")]
    [IsoXmlTag("TmPrdUnit")]
    public Max4NumericText? TimePeriodUnit { get; init; }

    /// <summary>
    /// Time Period Rate.
    /// </summary>
    [DisplayName("Time Period Rate")]
    [IsoXmlTag("TmPrdRate")]
    public ImpliedCurrencyAndAmount? TimePeriodRate { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }
}
