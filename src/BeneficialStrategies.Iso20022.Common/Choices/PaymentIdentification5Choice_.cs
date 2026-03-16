// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways of identifying a payment instruction by its references and business identification.
    /// </summary>
    [KnownType(typeof(PaymentIdentification5Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PaymentIdentification5Choice.TransactionIdentification),
        nameof(PaymentIdentification5Choice.TransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification5Choice.QueueIdentification),
        nameof(PaymentIdentification5Choice.QueueIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification5Choice.LongBusinessIdentification),
        nameof(PaymentIdentification5Choice.LongBusinessIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification5Choice.ShortBusinessIdentification),
        nameof(PaymentIdentification5Choice.ShortBusinessIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification5Choice.ProprietaryIdentification),
        nameof(PaymentIdentification5Choice.ProprietaryIdentification)
    )]
    [IsoId("_UhbRcZlQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Identification 5 Choice")]
    public abstract record PaymentIdentification5Choice_ { }
}
