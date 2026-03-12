// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the status of the payment transaction.
    /// </summary>
    [KnownType(typeof(PaymentStatusReason1Choice.Unmatched))]
    [KnownType(typeof(PaymentStatusReason1Choice.Cancelled))]
    [KnownType(typeof(PaymentStatusReason1Choice.Suspended))]
    [KnownType(typeof(PaymentStatusReason1Choice.PendingFailingSettlement))]
    [KnownType(typeof(PaymentStatusReason1Choice.PendingSettlement))]
    [KnownType(typeof(PaymentStatusReason1Choice.ProprietaryRejection))]
    [KnownType(typeof(PaymentStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentStatusReason1Choice.Unmatched),nameof(PaymentStatusReason1Choice.Unmatched))]
    [JsonDerivedType(typeof(PaymentStatusReason1Choice.Cancelled),nameof(PaymentStatusReason1Choice.Cancelled))]
    [JsonDerivedType(typeof(PaymentStatusReason1Choice.Suspended),nameof(PaymentStatusReason1Choice.Suspended))]
    [JsonDerivedType(typeof(PaymentStatusReason1Choice.PendingFailingSettlement),nameof(PaymentStatusReason1Choice.PendingFailingSettlement))]
    [JsonDerivedType(typeof(PaymentStatusReason1Choice.PendingSettlement),nameof(PaymentStatusReason1Choice.PendingSettlement))]
    [JsonDerivedType(typeof(PaymentStatusReason1Choice.ProprietaryRejection),nameof(PaymentStatusReason1Choice.ProprietaryRejection))]
    [JsonDerivedType(typeof(PaymentStatusReason1Choice.Proprietary),nameof(PaymentStatusReason1Choice.Proprietary))]
    [IsoId("_QKoAqdEdEei798TPbKJMuw")]
    [DisplayName("Payment Status Reason 1 Choice")]
    public abstract partial record PaymentStatusReason1Choice_
    {
    }
}
