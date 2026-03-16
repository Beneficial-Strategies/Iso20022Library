// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of the PayInSchedule being confirmed. This is the Message Identification element from the Report Data sequence of the Pay In Schedule message.
/// </summary>
[IsoId("_SvM2AgEcEeCQm6a_G2yO_w_-502764871")]
[DisplayName("Confirmation Details")]
public record ConfirmationDetails1
{
    /// <summary>
    /// Reference to the pay in schedule confirmed.
    /// </summary>
    [IsoId("_SvM2AwEcEeCQm6a_G2yO_w_-1406647983")]
    [DisplayName("Pay In Schedule Reference")]
    [IsoXmlTag("PayInSchdlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PayInScheduleReference { get; init; }
}
