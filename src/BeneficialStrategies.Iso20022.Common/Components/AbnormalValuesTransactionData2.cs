// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
/// </summary>
[IsoId("_x6yxOVyGEe24CqbZJK5XxA")]
[DisplayName("Abnormal Values Transaction Data")]
public record AbnormalValuesTransactionData2
{
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_x7sJEVyGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; }

    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    [IsoId("_x7sJE1yGEe24CqbZJK5XxA")]
    [DisplayName("Notional Amount")]
    [IsoXmlTag("NtnlAmt")]
    public NotionalAmountLegs5? NotionalAmount { get; init; }

    /// <summary>
    /// Indicates for each leg of the transaction the total notional quantity of the underlying asset for the term of the transaction.
    /// </summary>
    [IsoId("_x7sJFVyGEe24CqbZJK5XxA")]
    [DisplayName("Notional Quantity")]
    [IsoXmlTag("NtnlQty")]
    public NotionalQuantityLegs5? NotionalQuantity { get; init; }
}
