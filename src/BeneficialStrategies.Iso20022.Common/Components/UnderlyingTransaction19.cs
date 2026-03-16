// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying (group of) transaction(s) to which the resolution of investigation applies.
/// </summary>
[IsoId("_r4psgYlrEeePr-EGJjGYzQ")]
[DisplayName("Underlying Transaction")]
public record UnderlyingTransaction19
{
    /// <summary>
    /// Provides information on the original cancellation message, to which the resolution refers.
    /// </summary>
    [IsoId("_sHR-Y4lrEeePr-EGJjGYzQ")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public OriginalGroupHeader9? OriginalGroupInformationAndStatus { get; init; }

    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation status refers.
    /// </summary>
    [IsoId("_sHR-ZYlrEeePr-EGJjGYzQ")]
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    public OriginalPaymentInstruction26? OriginalPaymentInformationAndStatus { get; init; }

    /// <summary>
    /// Provides details on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_sHR-Z4lrEeePr-EGJjGYzQ")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public PaymentTransaction85? TransactionInformationAndStatus { get; init; }
}
