// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying (group of) transaction(s) to which the investigation applies.
/// </summary>
[IsoId("_g5jg0dcZEeqRFcf2R4bPBw")]
[DisplayName("Underlying Transaction")]
public record UnderlyingTransaction30
{
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [IsoId("_g67Z3dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader15? OriginalGroupInformationAndCancellation { get; init; }

    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation request refers.
    /// </summary>
    [IsoId("_g67Z39cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Payment Information And Cancellation")]
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    public ValueList<OriginalPaymentInstruction44> OriginalPaymentInformationAndCancellation { get; init; } =
        [];
}
