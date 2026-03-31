// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
[IsoId("_SB0r1Np-Ed-ak6NoX_4Aeg_-865361430")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument8
{
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_SB0r1dp-Ed-ak6NoX_4Aeg_-865361290")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; }

    /// <summary>
    /// Cash account to debit for the payment of a subscription or of a savings plan to an investment fund.
    /// </summary>
    [IsoId("_SB0r1tp-Ed-ak6NoX_4Aeg_-865360952")]
    [DisplayName("Cash Account Details")]
    [IsoXmlTag("CshAcctDtls")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<CashAccount4> CashAccountDetails { get; init; } = [];

    /// <summary>
    /// Settlement instructions for a payment by card.
    /// </summary>
    [IsoId("_SB0r19p-Ed-ak6NoX_4Aeg_-864440809")]
    [DisplayName("Payment Card Details")]
    [IsoXmlTag("PmtCardDtls")]
    public required PaymentCard2 PaymentCardDetails { get; init; }

    /// <summary>
    /// Settlement instructions for a payment by direct debit.
    /// </summary>
    [IsoId("_SB0r2Np-Ed-ak6NoX_4Aeg_-865360858")]
    [DisplayName("Direct Debit Details")]
    [IsoXmlTag("DrctDbtDtls")]
    public required DirectDebitMandate4 DirectDebitDetails { get; init; }

    /// <summary>
    /// Indicates whether the payment is done via cheque.
    /// </summary>
    [IsoId("_SB0r2dp-Ed-ak6NoX_4Aeg_-865361256")]
    [DisplayName("Cheque")]
    [IsoXmlTag("Chq")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Cheque { get; init; }

    /// <summary>
    /// Indicates whether the payment is done via draft.
    /// </summary>
    [IsoId("_SB0r2tp-Ed-ak6NoX_4Aeg_-816417172")]
    [DisplayName("Bankers Draft")]
    [IsoXmlTag("BkrsDrft")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator BankersDraft { get; init; }
}
