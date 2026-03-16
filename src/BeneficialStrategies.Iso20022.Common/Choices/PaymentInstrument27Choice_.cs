// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Payment Instrument27Choice.
    /// </summary>
    [KnownType(typeof(PaymentInstrument27Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument27Choice.CashAccountDetails))]
    [KnownType(typeof(PaymentInstrument27Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument27Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument27Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument27Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument27Choice.BankersDraftDetails),nameof(PaymentInstrument27Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument27Choice.CashAccountDetails),nameof(PaymentInstrument27Choice.CashAccountDetails))]
    [JsonDerivedType(typeof(PaymentInstrument27Choice.ChequeDetails),nameof(PaymentInstrument27Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument27Choice.CreditTransferDetails),nameof(PaymentInstrument27Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument27Choice.DirectDebitDetails),nameof(PaymentInstrument27Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument27Choice.PaymentCardDetails),nameof(PaymentInstrument27Choice.PaymentCardDetails))]
    [IsoId("_5O9XJxwMEe6O0NdiBuX__w")]
    [DisplayName("Payment Instrument27Choice")]
    public abstract partial record PaymentInstrument27Choice_
    {
    }
}
