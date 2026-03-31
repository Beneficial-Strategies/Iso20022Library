// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways of identifying a payment instruction by its references and business identification.
    /// </summary>
    [KnownType(typeof(PaymentIdentification4Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PaymentIdentification4Choice.TransactionIdentification),
        nameof(PaymentIdentification4Choice.TransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification4Choice.QueueIdentification),
        nameof(PaymentIdentification4Choice.QueueIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification4Choice.LongBusinessIdentification),
        nameof(PaymentIdentification4Choice.LongBusinessIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification4Choice.ShortBusinessIdentification),
        nameof(PaymentIdentification4Choice.ShortBusinessIdentification)
    )]
    [JsonDerivedType(
        typeof(PaymentIdentification4Choice.ProprietaryIdentification),
        nameof(PaymentIdentification4Choice.ProprietaryIdentification)
    )]
    [IsoId("_74nuuKMgEeCJ6YNENx4h-w_753155238")]
    [DisplayName("Payment Identification 4 Choice")]
    public abstract record PaymentIdentification4Choice_ { }
}
