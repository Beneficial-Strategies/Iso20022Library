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
[IsoId("_u-SJX8vGEeihG9bKfarOOA")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection95
{
    /// <summary>
    /// Indicates whether the net proceeds include interest accrued on the financial instrument.
    /// </summary>
    [IsoId("_vQIuQcvGEeihG9bKfarOOA")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Whether the net proceeds include stamp duty amount.
    /// </summary>
    [IsoId("_vQIuRcvGEeihG9bKfarOOA")]
    [DisplayName("Stamp Duty Indicator")]
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StampDutyIndicator { get; init; }

    /// <summary>
    /// Indicates whether the net proceeds include brokerage fees for the transaction. If absent, element is not required.
    /// </summary>
    [IsoId("_vQIuScvGEeihG9bKfarOOA")]
    [DisplayName("Brokerage Amount Indicator")]
    [IsoXmlTag("BrkrgAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BrokerageAmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the net proceeds include research fees for the transaction.
    /// </summary>
    [IsoId("_zZ2VocvGEeihG9bKfarOOA")]
    [DisplayName("Research Fee Indicator")]
    [IsoXmlTag("RsrchFeeInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ResearchFeeIndicator { get; init; }

    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_vQIuS8vGEeihG9bKfarOOA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_vQIuT8vGEeihG9bKfarOOA")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_vQIuU8vGEeihG9bKfarOOA")]
    [DisplayName("Original Currency And Ordered Amount")]
    [IsoXmlTag("OrgnlCcyAndOrdrdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_vQIuV8vGEeihG9bKfarOOA")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_vQIuW8vGEeihG9bKfarOOA")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }
}
