// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on reservation.
/// </summary>
[IsoId("_kuH-C5laEeeE1Ya-LgRsuQ")]
[DisplayName("Reservation Return Criteria")]
public record ReservationReturnCriteria1
{
    /// <summary>
    /// Indicates whether the reservation start date time is requested.
    /// </summary>
    [IsoId("_k2a-YZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Start Date Time Indicator")]
    [IsoXmlTag("StartDtTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StartDateTimeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the reservation status is requested.
    /// </summary>
    [IsoId("_k2a-Y5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Status Indicator")]
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StatusIndicator { get; init; }
}
