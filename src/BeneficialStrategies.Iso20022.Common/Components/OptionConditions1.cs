// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conditions to be met by the holder.
/// </summary>
[IsoId("_Y41SoA7zEeuZI5Sr_GAcuA")]
[DisplayName("Option Conditions")]
public record OptionConditions1
{
    /// <summary>
    /// Number of the condition.
    /// </summary>
    [IsoId("_ogHwkA7zEeuZI5Sr_GAcuA")]
    [DisplayName("Condition Number")]
    [IsoXmlTag("CondNb")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    public required IsoMax1Number ConditionNumber { get; init; }

    /// <summary>
    /// Description of the condition.
    /// </summary>
    [IsoId("_Dj-YcA70EeuZI5Sr_GAcuA")]
    [DisplayName("Condition Text")]
    [IsoXmlTag("CondTxt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax520Text)]
    [StringLength(maximumLength: 520, MinimumLength = 1)]
    public required IsoRestrictedFINXMax520Text ConditionText { get; init; }

    /// <summary>
    /// States whether the condition must be acknowledged. Conditions with a No (&quot;false&quot; or &quot;0&quot;) do not need acknowledgement.
    /// </summary>
    [IsoId("_NpNjEA70EeuZI5Sr_GAcuA")]
    [DisplayName("Condition Required Flag")]
    [IsoXmlTag("CondReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ConditionRequiredFlag { get; init; }
}
