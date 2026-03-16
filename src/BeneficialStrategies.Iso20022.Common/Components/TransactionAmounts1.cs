// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the card transaction.
/// </summary>
[IsoId("_1-7FQESIEeeb1MmUPTrSMw")]
[DisplayName("Transaction Amounts")]
public record TransactionAmounts1
{
    /// <summary>
    /// Qualifier or type of amount.
    /// ISO 8583:93/2003 bit 24
    /// </summary>
    [IsoId("_AusaoESJEeeb1MmUPTrSMw")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount11Code? AmountQualifier { get; init; }

    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    [IsoId("_T6zDIESJEeeb1MmUPTrSMw")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public TransactionAmount1? TransactionAmount { get; init; }

    /// <summary>
    /// Present when the cardholder billing currency differs from the transaction currency expressed in the amount of the transaction. It may be populated by the card scheme or an intermediary processor as normally the acceptor does not know the billing currency for which the cardholder will be debited.
    /// </summary>
    [IsoId("_KdbJwESJEeeb1MmUPTrSMw")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public Amount4? CardholderBillingAmount { get; init; }

    /// <summary>
    /// Amount used for reconciliation.
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field
    /// </summary>
    [IsoId("_gwLaIESJEeeb1MmUPTrSMw")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount4? ReconciliationAmount { get; init; }

    /// <summary>
    /// Further details of some or all amounts in the transaction amount.
    /// </summary>
    [IsoId("_M9dY8EUKEeea986VZkEPUw")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount19? DetailedAmount { get; init; }

    /// <summary>
    /// Amount related to the original transaction.
    /// ISO 8583:87 bit 95
    /// ISO 8583:93/2003 bit 30
    /// </summary>
    [IsoId("_jFo7kEULEeea-M6VZkEPUw")]
    [DisplayName("Original Transaction Amounts")]
    [IsoXmlTag("OrgnlTxAmts")]
    public OriginalTransactionAmount1? OriginalTransactionAmounts { get; init; }
}
