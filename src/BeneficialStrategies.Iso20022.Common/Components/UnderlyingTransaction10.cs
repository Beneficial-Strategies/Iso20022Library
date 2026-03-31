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
[IsoId("_pLosJx72EeSxevWRRWxNAg")]
[DisplayName("Underlying Transaction")]
public record UnderlyingTransaction10
{
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [IsoId("_pdeC_R72EeSxevWRRWxNAg")]
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader4? OriginalGroupInformationAndCancellation { get; init; }

    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_pdeC_x72EeSxevWRRWxNAg")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction55> TransactionInformation { get; init; } = [];
}
