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
[IsoId("_A4s_EtokEeC60axPepSq7g_-893449260")]
[DisplayName("Unmatched Reason")]
public record UnmatchedReason5
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_A4s_E9okEeC60axPepSq7g_2038515075")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required UnmatchedReason7Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_A4s_FNokEeC60axPepSq7g_-2004360679")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
