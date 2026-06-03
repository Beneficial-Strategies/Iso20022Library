// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_fQGBsatmEfCqjuqNaaNXgw")]
[DisplayName("Period18")]
public record Period18
{
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_fXC-RatmEfCqjuqNaaNXgw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required DateFormat73Choice StartDate { get; init; }

    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_fXC-S6tmEfCqjuqNaaNXgw")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public required DateFormat73Choice EndDate { get; init; }
}
