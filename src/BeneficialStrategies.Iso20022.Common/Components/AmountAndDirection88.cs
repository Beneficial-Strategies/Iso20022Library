// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_4r9oQbPvEeelzbgsFa3sqQ")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection88
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_47Sds7PvEeelzbgsFa3sqQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_47Sdu7PvEeelzbgsFa3sqQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_47Sdw7PvEeelzbgsFa3sqQ")]
    [DisplayName("Original Currency And Ordered Amount")]
    [IsoXmlTag("OrgnlCcyAndOrdrdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_47Sdy7PvEeelzbgsFa3sqQ")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_47Sd07PvEeelzbgsFa3sqQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }
}
