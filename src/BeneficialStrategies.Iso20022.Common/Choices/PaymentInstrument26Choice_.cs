// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Payment Instrument26Choice.
    /// </summary>
    [KnownType(typeof(PaymentInstrument26Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument26Choice.CashAccountDetails))]
    [KnownType(typeof(PaymentInstrument26Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument26Choice.CreditTransferDetails))]
    [JsonDerivedType(
        typeof(PaymentInstrument26Choice.BankersDraftDetails),
        nameof(PaymentInstrument26Choice.BankersDraftDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument26Choice.CashAccountDetails),
        nameof(PaymentInstrument26Choice.CashAccountDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument26Choice.ChequeDetails),
        nameof(PaymentInstrument26Choice.ChequeDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument26Choice.CreditTransferDetails),
        nameof(PaymentInstrument26Choice.CreditTransferDetails)
    )]
    [IsoId("_0DGWRxwMEe6O0NdiBuX__w")]
    [DisplayName("Payment Instrument26Choice")]
    public abstract record PaymentInstrument26Choice_ { }
}
