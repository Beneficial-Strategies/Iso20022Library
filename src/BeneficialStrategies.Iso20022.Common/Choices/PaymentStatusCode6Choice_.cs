// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a list of pending statuses or final statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCode6Choice.Pending))]
    [KnownType(typeof(PaymentStatusCode6Choice.Final))]
    [KnownType(typeof(PaymentStatusCode6Choice.RTGS))]
    [KnownType(typeof(PaymentStatusCode6Choice.Settlement))]
    [KnownType(typeof(PaymentStatusCode6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PaymentStatusCode6Choice.Pending),
        nameof(PaymentStatusCode6Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(PaymentStatusCode6Choice.Final),
        nameof(PaymentStatusCode6Choice.Final)
    )]
    [JsonDerivedType(typeof(PaymentStatusCode6Choice.RTGS), nameof(PaymentStatusCode6Choice.RTGS))]
    [JsonDerivedType(
        typeof(PaymentStatusCode6Choice.Settlement),
        nameof(PaymentStatusCode6Choice.Settlement)
    )]
    [JsonDerivedType(
        typeof(PaymentStatusCode6Choice.Proprietary),
        nameof(PaymentStatusCode6Choice.Proprietary)
    )]
    [IsoId("_pIXBKRbzEeOy-PlRuFSUzQ")]
    [DisplayName("Payment Status Code 6 Choice")]
    public abstract record PaymentStatusCode6Choice_ { }
}
