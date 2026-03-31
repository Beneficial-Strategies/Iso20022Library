// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [KnownType(typeof(PaymentInstrument17Choice.CashAccountDetails))]
    [KnownType(typeof(PaymentInstrument17Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument17Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument17Choice.Cheque))]
    [KnownType(typeof(PaymentInstrument17Choice.BankersDraft))]
    [JsonDerivedType(
        typeof(PaymentInstrument17Choice.CashAccountDetails),
        nameof(PaymentInstrument17Choice.CashAccountDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument17Choice.PaymentCardDetails),
        nameof(PaymentInstrument17Choice.PaymentCardDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument17Choice.DirectDebitDetails),
        nameof(PaymentInstrument17Choice.DirectDebitDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument17Choice.Cheque),
        nameof(PaymentInstrument17Choice.Cheque)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument17Choice.BankersDraft),
        nameof(PaymentInstrument17Choice.BankersDraft)
    )]
    [IsoId("_dK0IcxdHEeK5g-3oYI0_9Q")]
    [DisplayName("Payment Instrument 17 Choice")]
    public abstract record PaymentInstrument17Choice_ { }
}
