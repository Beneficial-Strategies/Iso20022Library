// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Underlying Transaction33.
/// </summary>
[IsoId("_9c2ggTEsEe6GxLzpkVnWYg")]
[DisplayName("Underlying Transaction33")]
public record UnderlyingTransaction33
{
    /// <summary>
    /// Original Group Information And Cancellation.
    /// </summary>
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader21? OriginalGroupInformationAndCancellation { get; init; }

    /// <summary>
    /// Original Payment Information And Cancellation.
    /// </summary>
    [DisplayName("Original Payment Information And Cancellation")]
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    public ValueList<OriginalPaymentInstruction49> OriginalPaymentInformationAndCancellation { get; init; } =
        [];
}
