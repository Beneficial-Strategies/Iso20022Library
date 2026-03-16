// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action date.
/// </summary>
[IsoId("__FQ90TQKEe2o-K1dwNg8Gg")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate88
{
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("__cNeUzQKEe2o-K1dwNg8Gg")]
    [DisplayName("Cover Expiration Deadline")]
    [IsoXmlTag("CoverXprtnDdln")]
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; }

    /// <summary>
    /// Date/time at which the deal (rights) was agreed.
    /// </summary>
    [IsoId("__cNeYzQKEe2o-K1dwNg8Gg")]
    [DisplayName("Trading Date")]
    [IsoXmlTag("TradgDt")]
    public DateFormat43Choice_? TradingDate { get; init; }
}
