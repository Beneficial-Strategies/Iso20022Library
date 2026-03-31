// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [KnownType(typeof(PaymentInstrument9Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.AccountDetails))]
    [JsonDerivedType(
        typeof(PaymentInstrument9Choice.PaymentCardDetails),
        nameof(PaymentInstrument9Choice.PaymentCardDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument9Choice.CreditTransferDetails),
        nameof(PaymentInstrument9Choice.CreditTransferDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument9Choice.DirectDebitDetails),
        nameof(PaymentInstrument9Choice.DirectDebitDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument9Choice.ChequeDetails),
        nameof(PaymentInstrument9Choice.ChequeDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument9Choice.AccountDetails),
        nameof(PaymentInstrument9Choice.AccountDetails)
    )]
    [IsoId("_VKshR9p-Ed-ak6NoX_4Aeg_852770854")]
    [DisplayName("Payment Instrument 9 Choice")]
    public abstract record PaymentInstrument9Choice_ { }
}
