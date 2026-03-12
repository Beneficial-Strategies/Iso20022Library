// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways of identifying a payment instruction by its references and business identification.
    /// </summary>
    [KnownType(typeof(PaymentIdentification7Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.UETR))]
    [KnownType(typeof(PaymentIdentification7Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification7Choice.TransactionIdentification),nameof(PaymentIdentification7Choice.TransactionIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification7Choice.UETR),nameof(PaymentIdentification7Choice.UETR))]
    [JsonDerivedType(typeof(PaymentIdentification7Choice.QueueIdentification),nameof(PaymentIdentification7Choice.QueueIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification7Choice.LongBusinessIdentification),nameof(PaymentIdentification7Choice.LongBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification7Choice.ShortBusinessIdentification),nameof(PaymentIdentification7Choice.ShortBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification7Choice.ProprietaryIdentification),nameof(PaymentIdentification7Choice.ProprietaryIdentification))]
    [IsoId("_5F42wAKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment Identification 7 Choice")]
    public abstract partial record PaymentIdentification7Choice_
    {
    }
}
