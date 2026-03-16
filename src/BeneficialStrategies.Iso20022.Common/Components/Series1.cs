// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a series.
/// </summary>
[IsoId("_ZD4mEEgQEea9YuSvQGoi-w")]
[DisplayName("Series")]
public record Series1
{
    /// <summary>
    /// Issue date of the fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription order, if known.
    /// </summary>
    [IsoId("_Cf7MoJBsEeaGiLsfv6g8MA")]
    [DisplayName("Series Date")]
    [IsoXmlTag("SrsDt")]
    public DateFormat42Choice_? SeriesDate { get; init; }

    /// <summary>
    /// Name of the fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription, if known.
    /// </summary>
    [IsoId("_81Imc0gREea9YuSvQGoi-w")]
    [DisplayName("Series Name")]
    [IsoXmlTag("SrsNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SeriesName { get; init; }
}
