// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [KnownType(typeof(PaymentInstrument24Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument24Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument24Choice.Cheque))]
    [KnownType(typeof(PaymentInstrument24Choice.BankersDraft))]
    [JsonDerivedType(
        typeof(PaymentInstrument24Choice.PaymentCardDetails),
        nameof(PaymentInstrument24Choice.PaymentCardDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument24Choice.DirectDebitDetails),
        nameof(PaymentInstrument24Choice.DirectDebitDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument24Choice.Cheque),
        nameof(PaymentInstrument24Choice.Cheque)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument24Choice.BankersDraft),
        nameof(PaymentInstrument24Choice.BankersDraft)
    )]
    [IsoId("_JSXkMZTBEemqYPWMBuVawg")]
    [DisplayName("Payment Instrument 24 Choice")]
    public abstract record PaymentInstrument24Choice_ { }
}
