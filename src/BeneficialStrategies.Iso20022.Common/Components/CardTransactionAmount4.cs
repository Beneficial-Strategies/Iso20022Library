// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the transaction expressed within the terminal currency.
/// </summary>
[IsoId("_DmWOsYNwEeSXtJ8rlirVJw")]
[DisplayName("Card Transaction Amount")]
public record CardTransactionAmount4
{
    /// <summary>
    /// Total amount of the transaction.
    /// It corresponds to ISO 8583, field number 4, completed by the field number 49 for the versions 87 and 93.
    /// </summary>
    [IsoId("_Dz6woYNwEeSXtJ8rlirVJw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Present when cardholder billing currency differs from transaction currency expressed in TransactionAmount. It may be populated by the scheme or intermediary processor as normally Acceptor does not know cardholder billing currency.
    /// </summary>
    [IsoId("_Dz6wo4NwEeSXtJ8rlirVJw")]
    [DisplayName("Cardholder Billing Transaction Amount")]
    [IsoXmlTag("CrdhldrBllgTxAmt")]
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; }

    /// <summary>
    /// Only present within financial transactions when reconciliation currency differs from transaction currency. It may be populated by acquirers in the request or by the schemes in the responses, depending where the reconciliation point is located.
    /// </summary>
    [IsoId("_MC_q4INwEeSXtJ8rlirVJw")]
    [DisplayName("Reconciliation Transaction Amount")]
    [IsoXmlTag("RcncltnTxAmt")]
    public DetailedAmount8? ReconciliationTransactionAmount { get; init; }

    /// <summary>
    /// Details of the TransactionAmount, for informational purposes only, except for cash back which is mandatory for a payment transaction with cashback. The transaction amount is not necessarly the sum of all the detailed amount values.
    /// </summary>
    [IsoId("_Dz6wpYNwEeSXtJ8rlirVJw")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount9? DetailedAmount { get; init; }
}
