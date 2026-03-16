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
[IsoId("_UZEQANp-Ed-ak6NoX_4Aeg_-1417428897")]
[DisplayName("Cancellation Reason")]
public record CancellationReason1
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    [IsoId("_UZEQAdp-Ed-ak6NoX_4Aeg_644022432")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CancellationReason5Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UZEQAtp-Ed-ak6NoX_4Aeg_-1472361575")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
