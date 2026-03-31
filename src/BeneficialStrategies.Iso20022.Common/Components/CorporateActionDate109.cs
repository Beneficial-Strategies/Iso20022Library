// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Date109.
/// </summary>
[IsoId("_XDQtMKAXEe-6zfgb2Rwrlw")]
[DisplayName("Corporate Action Date109")]
public record CorporateActionDate109
{
    /// <summary>
    /// Cover Expiration Deadline.
    /// </summary>
    [DisplayName("Cover Expiration Deadline")]
    [IsoXmlTag("CoverXprtnDdln")]
    public DateFormat67Choice_? CoverExpirationDeadline { get; init; }

    /// <summary>
    /// Trading Date.
    /// </summary>
    [DisplayName("Trading Date")]
    [IsoXmlTag("TradgDt")]
    public DateFormat49Choice_? TradingDate { get; init; }
}
