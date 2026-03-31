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
[IsoId("_0jExAwlIEeGATtfOBToyew_2075567682")]
[DisplayName("Pending Processing Reason")]
public record PendingProcessingReason5
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    [IsoId("_0jExBAlIEeGATtfOBToyew_-502315511")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PendingProcessingReason5Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_0jExBQlIEeGATtfOBToyew_568847003")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
