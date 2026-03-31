// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_A6DC49okEeC60axPepSq7g_1097982212")]
[DisplayName("Affirmation Reason")]
public record AffirmationReason1
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a unaffirmed status.
    /// </summary>
    [IsoId("_A6DC5NokEeC60axPepSq7g_-2010415618")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required UnaffirmedReason2Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_A6DC5dokEeC60axPepSq7g_1520117443")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
