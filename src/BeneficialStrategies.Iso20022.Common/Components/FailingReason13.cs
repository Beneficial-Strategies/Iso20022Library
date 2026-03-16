// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Failing Reason13.
/// </summary>
[IsoId("_8xVDEYcTEe-FecylWsA1vA")]
[DisplayName("Failing Reason13")]
public record FailingReason13
{
    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Code.
    /// </summary>
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required FailingReason18Choice_ Code { get; init; }
}
