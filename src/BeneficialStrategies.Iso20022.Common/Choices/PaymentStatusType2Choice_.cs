// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates the status of the payment, either as a raw status, or as a detailed status.
    /// </summary>
    [KnownType(typeof(PaymentStatusType2Choice.RawStatus))]
    [KnownType(typeof(PaymentStatusType2Choice.DetailedStatus))]
    [JsonDerivedType(typeof(PaymentStatusType2Choice.RawStatus),nameof(PaymentStatusType2Choice.RawStatus))]
    [JsonDerivedType(typeof(PaymentStatusType2Choice.DetailedStatus),nameof(PaymentStatusType2Choice.DetailedStatus))]
    [IsoId("_CuMfQSYMEei7VPGVFTQkxA")]
    [DisplayName("Payment Status Type 2 Choice")]
    public abstract partial record PaymentStatusType2Choice_
    {
    }
}
