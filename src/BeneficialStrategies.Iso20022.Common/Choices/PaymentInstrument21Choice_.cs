// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, that is, cheque, credit transfer or investment account.
    /// </summary>
    [KnownType(typeof(PaymentInstrument21Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument21Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument21Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument21Choice.CashAccountDetails))]
    [JsonDerivedType(
        typeof(PaymentInstrument21Choice.CreditTransferDetails),
        nameof(PaymentInstrument21Choice.CreditTransferDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument21Choice.ChequeDetails),
        nameof(PaymentInstrument21Choice.ChequeDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument21Choice.BankersDraftDetails),
        nameof(PaymentInstrument21Choice.BankersDraftDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument21Choice.CashAccountDetails),
        nameof(PaymentInstrument21Choice.CashAccountDetails)
    )]
    [IsoId("_3zQJVzbsEead9bDRE_1DAQ")]
    [DisplayName("Payment Instrument 21 Choice")]
    public abstract record PaymentInstrument21Choice_ { }
}
