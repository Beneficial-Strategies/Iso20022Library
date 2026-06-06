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
[IsoId("9d21a9f8-06d5-4933-b592-aaef2329e508")]
[DisplayName("Underlying Transaction37")]
public record UnderlyingTransaction37
{
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [IsoId("c631af28-7027-46d0-9a5d-978eb675126f")]
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader21? OriginalGroupInformationAndCancellation { get; init; }

    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation request refers.
    /// </summary>
    [IsoId("2820f4ae-72a0-4851-adf8-d66d2ddfc960")]
    [DisplayName("Original Payment Information And Cancellation")]
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    public ValueList<OriginalPaymentInstruction55> OriginalPaymentInformationAndCancellation { get; init; } = [];
}
