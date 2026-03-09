// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the status of the transaction.
    /// </summary>
    [KnownType(typeof(PaymentStatusReasonCode7Choice.Unmatched))]
    [KnownType(typeof(PaymentStatusReasonCode7Choice.Cancelled))]
    [KnownType(typeof(PaymentStatusReasonCode7Choice.Suspended))]
    [KnownType(typeof(PaymentStatusReasonCode7Choice.PendingFailingSettlement))]
    [KnownType(typeof(PaymentStatusReasonCode7Choice.PendingSettlement))]
    [KnownType(typeof(PaymentStatusReasonCode7Choice.ProprietaryRejection))]
    [KnownType(typeof(PaymentStatusReasonCode7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentStatusReasonCode7Choice.Unmatched),nameof(PaymentStatusReasonCode7Choice.Unmatched))]
    [JsonDerivedType(typeof(PaymentStatusReasonCode7Choice.Cancelled),nameof(PaymentStatusReasonCode7Choice.Cancelled))]
    [JsonDerivedType(typeof(PaymentStatusReasonCode7Choice.Suspended),nameof(PaymentStatusReasonCode7Choice.Suspended))]
    [JsonDerivedType(typeof(PaymentStatusReasonCode7Choice.PendingFailingSettlement),nameof(PaymentStatusReasonCode7Choice.PendingFailingSettlement))]
    [JsonDerivedType(typeof(PaymentStatusReasonCode7Choice.PendingSettlement),nameof(PaymentStatusReasonCode7Choice.PendingSettlement))]
    [JsonDerivedType(typeof(PaymentStatusReasonCode7Choice.ProprietaryRejection),nameof(PaymentStatusReasonCode7Choice.ProprietaryRejection))]
    [JsonDerivedType(typeof(PaymentStatusReasonCode7Choice.Proprietary),nameof(PaymentStatusReasonCode7Choice.Proprietary))]
    #endif
    [IsoId("_NqBxSZlPEee-Zps0fZQaFQ")]
    [DisplayName("Payment Status Reason Code 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusReasonCode7Choice_
    #else
    public abstract partial class PaymentStatusReasonCode7Choice_
    #endif
    {
    }
}
