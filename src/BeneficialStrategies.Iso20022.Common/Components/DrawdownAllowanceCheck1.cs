// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Drawdown allowance check. For pensions that have a lifetime allowance, a check is made of the maximum value of benefits that may be taken from the pension without incurring a special tax. (This check or &apos;event&apos; is known as the benefit crystallisation event in the UK market.)
/// </summary>
[IsoId("_6Oo4kLGuEeirN-C08vro8Q")]
[DisplayName("Drawdown Allowance Check")]
public record DrawdownAllowanceCheck1
{
    /// <summary>
    /// Indicates the Benefit Crystallised Event (BCE).
    /// If the Benefit Crystallised Event (BCE ) is other than 1 and 6 then the BCEIndicator must contain the value &quot;true&apos;.
    /// If the Benefit Crystallised Event (BCE ) is 1 or 6 then the BCEIndicator must contain the value false&apos;.
    /// </summary>
    [IsoId("_Y6dFoLGvEeirN-C08vro8Q")]
    [DisplayName("BCE Indicator")]
    [IsoXmlTag("BCEInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BCEIndicator { get; init; }

    /// <summary>
    /// Species information about the drawdown allowance check.
    /// </summary>
    [IsoId("_cZUZMLGvEeirN-C08vro8Q")]
    [DisplayName("Check Information")]
    [IsoXmlTag("ChckInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? CheckInformation { get; init; }
}
