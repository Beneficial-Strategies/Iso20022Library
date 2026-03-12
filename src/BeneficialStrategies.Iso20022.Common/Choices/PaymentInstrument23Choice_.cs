// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument.
    /// </summary>
    [KnownType(typeof(PaymentInstrument23Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument23Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument23Choice.CreditTransferDetails),nameof(PaymentInstrument23Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument23Choice.ChequeDetails),nameof(PaymentInstrument23Choice.ChequeDetails))]
    [IsoId("_Z55NsFNaEeijdq8ilaxyOA")]
    [DisplayName("Payment Instrument 23 Choice")]
    public abstract partial record PaymentInstrument23Choice_
    {
    }
}
