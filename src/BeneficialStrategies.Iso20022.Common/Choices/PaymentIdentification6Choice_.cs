// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways of identifying a payment instruction by its references and business identification.
    /// </summary>
    [KnownType(typeof(PaymentIdentification6Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PaymentIdentification6Choice.TransactionIdentification),
        nameof(PaymentIdentification6Choice.TransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification6Choice.QueueIdentification),
        nameof(PaymentIdentification6Choice.QueueIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification6Choice.LongBusinessIdentification),
        nameof(PaymentIdentification6Choice.LongBusinessIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification6Choice.ShortBusinessIdentification),
        nameof(PaymentIdentification6Choice.ShortBusinessIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification6Choice.ProprietaryIdentification),
        nameof(PaymentIdentification6Choice.ProprietaryIdentification)
    )]
    [IsoId("_AW_FQ24-EeiU9cctagi5ow")]
    [DisplayName("Payment Identification 6 Choice")]
    public abstract record PaymentIdentification6Choice_ { }
}
