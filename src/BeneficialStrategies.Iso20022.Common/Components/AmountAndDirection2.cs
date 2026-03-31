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
[IsoId("_SUcs49p-Ed-ak6NoX_4Aeg_-2041884579")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection2
{
    /// <summary>
    /// Indicates whether the net proceeds include interest accrued on the financial instrument.
    /// </summary>
    [IsoId("_SUcs5Np-Ed-ak6NoX_4Aeg_-2041884561")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Whether the net proceeds include stamp duty amount.
    /// </summary>
    [IsoId("_SUcs5dp-Ed-ak6NoX_4Aeg_-2041884536")]
    [DisplayName("Stamp Duty Indicator")]
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StampDutyIndicator { get; init; }

    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_SUcs5tp-Ed-ak6NoX_4Aeg_-2041884519")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_SUcs59p-Ed-ak6NoX_4Aeg_-2041884484")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_SUcs6Np-Ed-ak6NoX_4Aeg_-2041884501")]
    [DisplayName("Original Currency And Ordered Amount")]
    [IsoXmlTag("OrgnlCcyAndOrdrdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_SUcs6dp-Ed-ak6NoX_4Aeg_453780378")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_SUcs6tp-Ed-ak6NoX_4Aeg_-2001237107")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; }
}
