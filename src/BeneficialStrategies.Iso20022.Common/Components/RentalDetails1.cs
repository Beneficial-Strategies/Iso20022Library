// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of car rental service.
/// </summary>
[IsoId("_VJhKgF1rEeeu75xdwwAXQw")]
[DisplayName("Rental Details")]
public record RentalDetails1
{
    /// <summary>
    /// Identification of the car rental service.
    /// </summary>
    [IsoId("_edrrQF1wEeeu75xdwwAXQw")]
    [DisplayName("Rental Identification")]
    [IsoXmlTag("RntlId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? RentalIdentification { get; init; }

    /// <summary>
    /// Date and time of registration of car rental service as  per folio.
    /// </summary>
    [IsoId("_sEAXAF1wEeeu75xdwwAXQw")]
    [DisplayName("Rental Date Time")]
    [IsoXmlTag("RntlDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RentalDateTime { get; init; }

    /// <summary>
    /// Details of the vehicle at the start of the rental period.
    /// </summary>
    [IsoId("_lNkc8F1rEeeu75xdwwAXQw")]
    [DisplayName("Rental Start")]
    [IsoXmlTag("RntlStart")]
    public ServiceStartEnd1? RentalStart { get; init; }

    /// <summary>
    /// Details of the vehicle at the end of the rental period.
    /// </summary>
    [IsoId("_qDUD4F1rEeeu75xdwwAXQw")]
    [DisplayName("Rental Return")]
    [IsoXmlTag("RntlRtr")]
    public ServiceStartEnd1? RentalReturn { get; init; }

    /// <summary>
    /// Time period for the whole duration of rental.
    /// </summary>
    [IsoId("_yw6tMF1rEeeu75xdwwAXQw")]
    [DisplayName("Rental Time Period")]
    [IsoXmlTag("RntlTmPrd")]
    public PeriodUnit2Code? RentalTimePeriod { get; init; }

    /// <summary>
    /// Time period expressed in a number of units (for example, 1 week, 3 days, etc.).
    /// </summary>
    [IsoId("_x6MrIF1sEeeu75xdwwAXQw")]
    [DisplayName("Time Period Unit")]
    [IsoXmlTag("TmPrdUnit")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? TimePeriodUnit { get; init; }

    /// <summary>
    /// Rate for the time period.
    /// </summary>
    [IsoId("_7w_xIF1sEeeu75xdwwAXQw")]
    [DisplayName("Time Period Rate")]
    [IsoXmlTag("TmPrdRate")]
    public ImpliedCurrencyAndAmount? TimePeriodRate { get; init; }

    /// <summary>
    /// Currency code applied for the rental.
    /// </summary>
    [IsoId("_Em73EF1tEeeu75xdwwAXQw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }
}
