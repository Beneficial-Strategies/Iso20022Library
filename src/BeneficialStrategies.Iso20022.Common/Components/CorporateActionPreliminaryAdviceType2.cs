// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of movement preliminary advice document.
/// </summary>
[IsoId("_hX_uQSqeEeObprHJy8Zrxg")]
[DisplayName("Corporate Action Preliminary Advice Type")]
public record CorporateActionPreliminaryAdviceType2
{
    /// <summary>
    /// Type of movement preliminary advice, for example. new or replacement.
    /// </summary>
    [IsoId("_hvNUYSqeEeObprHJy8Zrxg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; }

    /// <summary>
    /// Indicates whether the movement preliminary advice is sent after entitlement date.
    /// Value is Yes (true) if sent after entitlement date and No (false) if sent before entitlement date.
    /// </summary>
    [IsoId("_hvNUcSqeEeObprHJy8Zrxg")]
    [DisplayName("Eligibility Indicator")]
    [IsoXmlTag("ElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibilityIndicator { get; init; }
}
