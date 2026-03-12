// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, ie, credit transfer, cheque, payment card, investment cash account or direct debit.
    /// </summary>
    [KnownType(typeof(PaymentInstrument10Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.AccountDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.PaymentCardDetails),nameof(PaymentInstrument10Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.CreditTransferDetails),nameof(PaymentInstrument10Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.DirectDebitDetails),nameof(PaymentInstrument10Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.ChequeDetails),nameof(PaymentInstrument10Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.AccountDetails),nameof(PaymentInstrument10Choice.AccountDetails))]
    [IsoId("_VKY_Rtp-Ed-ak6NoX_4Aeg_734057873")]
    [DisplayName("Payment Instrument 10 Choice")]
    public abstract partial record PaymentInstrument10Choice_
    {
    }
}
