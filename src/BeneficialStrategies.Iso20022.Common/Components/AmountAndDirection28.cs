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
[IsoId("_Aj2JYNokEeC60axPepSq7g_1906017147")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection28
{
    /// <summary>
    /// Indicates whether the net proceeds include interest accrued on the financial instrument.
    /// </summary>
    [IsoId("_Aj2JYdokEeC60axPepSq7g_1792178081")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_Aj2JYtokEeC60axPepSq7g_795105728")]
    [DisplayName("Stamp Duty Indicator")]
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StampDutyIndicator { get; init; }

    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_Aj_TUNokEeC60axPepSq7g_-201966625")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_Aj_TUdokEeC60axPepSq7g_-1199038978")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_Aj_TUtokEeC60axPepSq7g_-1904153593")]
    [DisplayName("Original Currency And Ordered Amount")]
    [IsoXmlTag("OrgnlCcyAndOrdrdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_Aj_TU9okEeC60axPepSq7g_1393741350")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms18? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_Aj_TVNokEeC60axPepSq7g_396668997")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime1Choice_? ValueDate { get; init; }
}
