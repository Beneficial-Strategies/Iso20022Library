// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [KnownType(typeof(PaymentInstrument18Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument18Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument18Choice.Cheque))]
    [KnownType(typeof(PaymentInstrument18Choice.BankersDraft))]
    [JsonDerivedType(
        typeof(PaymentInstrument18Choice.PaymentCardDetails),
        nameof(PaymentInstrument18Choice.PaymentCardDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument18Choice.DirectDebitDetails),
        nameof(PaymentInstrument18Choice.DirectDebitDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument18Choice.Cheque),
        nameof(PaymentInstrument18Choice.Cheque)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument18Choice.BankersDraft),
        nameof(PaymentInstrument18Choice.BankersDraft)
    )]
    [IsoId("_fNjxsSC1EeWJd9HF2tO7BA")]
    [DisplayName("Payment Instrument 18 Choice")]
    public abstract record PaymentInstrument18Choice_ { }
}
