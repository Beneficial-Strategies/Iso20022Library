// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Payment Identification8Choice.
    /// </summary>
    [KnownType(typeof(PaymentIdentification8Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification8Choice.ProprietaryIdentification))]
    [KnownType(typeof(PaymentIdentification8Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification8Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification8Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification8Choice.UETR))]
    [JsonDerivedType(typeof(PaymentIdentification8Choice.LongBusinessIdentification),nameof(PaymentIdentification8Choice.LongBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification8Choice.ProprietaryIdentification),nameof(PaymentIdentification8Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification8Choice.QueueIdentification),nameof(PaymentIdentification8Choice.QueueIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification8Choice.ShortBusinessIdentification),nameof(PaymentIdentification8Choice.ShortBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification8Choice.TransactionIdentification),nameof(PaymentIdentification8Choice.TransactionIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification8Choice.UETR),nameof(PaymentIdentification8Choice.UETR))]
    [IsoId("_1-XG8TEyEe6g-ffJsqGiSA")]
    [DisplayName("Payment Identification8Choice")]
    public abstract partial record PaymentIdentification8Choice_
    {
    }
}
