// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [KnownType(typeof(PaymentInstrument8Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.AccountDetails))]
    [JsonDerivedType(
        typeof(PaymentInstrument8Choice.PaymentCardDetails),
        nameof(PaymentInstrument8Choice.PaymentCardDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument8Choice.CreditTransferDetails),
        nameof(PaymentInstrument8Choice.CreditTransferDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument8Choice.DirectDebitDetails),
        nameof(PaymentInstrument8Choice.DirectDebitDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument8Choice.ChequeDetails),
        nameof(PaymentInstrument8Choice.ChequeDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument8Choice.AccountDetails),
        nameof(PaymentInstrument8Choice.AccountDetails)
    )]
    [IsoId("_VKshQdp-Ed-ak6NoX_4Aeg_-704155609")]
    [DisplayName("Payment Instrument 8 Choice")]
    public abstract record PaymentInstrument8Choice_ { }
}
