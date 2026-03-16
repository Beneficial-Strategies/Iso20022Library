// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument.
    /// </summary>
    [KnownType(typeof(PaymentInstrument25Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument25Choice.ChequeDetails))]
    [JsonDerivedType(
        typeof(PaymentInstrument25Choice.CreditTransferDetails),
        nameof(PaymentInstrument25Choice.CreditTransferDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument25Choice.ChequeDetails),
        nameof(PaymentInstrument25Choice.ChequeDetails)
    )]
    [IsoId("_MoD1sf8REemYYvJytExgzA")]
    [DisplayName("Payment Instrument 25 Choice")]
    public abstract record PaymentInstrument25Choice_ { }
}
