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
[IsoId("_QMXx0bPgEeeppqgHuc69jg")]
[DisplayName("Underlying Transaction")]
public record UnderlyingTransaction21
{
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [IsoId("_QUjdf7PgEeeppqgHuc69jg")]
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader10? OriginalGroupInformationAndCancellation { get; init; }

    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation request refers.
    /// </summary>
    [IsoId("_QUjdgbPgEeeppqgHuc69jg")]
    [DisplayName("Original Payment Information And Cancellation")]
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    public ValueList<OriginalPaymentInstruction29> OriginalPaymentInformationAndCancellation { get; init; } =
        [];
}
