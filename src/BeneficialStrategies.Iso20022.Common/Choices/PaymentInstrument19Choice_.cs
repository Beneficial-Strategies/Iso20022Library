// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [KnownType(typeof(PaymentInstrument19Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument19Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument19Choice.ChequeDetails),nameof(PaymentInstrument19Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument19Choice.BankersDraftDetails),nameof(PaymentInstrument19Choice.BankersDraftDetails))]
    [IsoId("_-J8xYSC1EeWJd9HF2tO7BA")]
    [DisplayName("Payment Instrument 19 Choice")]
    public abstract partial record PaymentInstrument19Choice_
    {
    }
}
