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
[IsoId("_2-L0LQd3Ee2fOITqoTnSLQ")]
[DisplayName("Allegement Matching Reason")]
public record AllegementMatchingReason2
{
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    [IsoId("_3TyQsQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AllegementReason2Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_3TyQswd3Ee2fOITqoTnSLQ")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
