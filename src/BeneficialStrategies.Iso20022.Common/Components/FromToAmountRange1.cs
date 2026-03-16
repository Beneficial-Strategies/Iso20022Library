// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
[IsoId("_jomKS5ljEeeE1Ya-LgRsuQ")]
[DisplayName("From To Amount Range")]
public record FromToAmountRange1
{
    /// <summary>
    /// Lower boundary of a range of amount values.
    /// </summary>
    [IsoId("_jw5KoZljEeeE1Ya-LgRsuQ")]
    [DisplayName("From Amount")]
    [IsoXmlTag("FrAmt")]
    public required AmountRangeBoundary1 FromAmount { get; init; }

    /// <summary>
    /// Upper boundary of a range of amount values.
    /// </summary>
    [IsoId("_jw5Ko5ljEeeE1Ya-LgRsuQ")]
    [DisplayName("To Amount")]
    [IsoXmlTag("ToAmt")]
    public required AmountRangeBoundary1 ToAmount { get; init; }
}
