// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [KnownType(typeof(PaymentInstrument16Choice.CashAccountDetails))]
    [KnownType(typeof(PaymentInstrument16Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument16Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument16Choice.CashAccountDetails),nameof(PaymentInstrument16Choice.CashAccountDetails))]
    [JsonDerivedType(typeof(PaymentInstrument16Choice.ChequeDetails),nameof(PaymentInstrument16Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument16Choice.BankersDraftDetails),nameof(PaymentInstrument16Choice.BankersDraftDetails))]
    [IsoId("_kj1SgRdJEeK5g-3oYI0_9Q")]
    [DisplayName("Payment Instrument 16 Choice")]
    public abstract partial record PaymentInstrument16Choice_
    {
    }
}
