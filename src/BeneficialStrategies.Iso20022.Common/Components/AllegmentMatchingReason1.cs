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
[IsoId("_A4j1I9okEeC60axPepSq7g_-1544737926")]
[DisplayName("Allegment Matching Reason")]
public record AllegmentMatchingReason1
{
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    [IsoId("_A4j1JNokEeC60axPepSq7g_-40057461")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AllegmentReason1Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_A4j1JdokEeC60axPepSq7g_-604585106")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
