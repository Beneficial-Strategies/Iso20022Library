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
    /// Choice between a list of pending statuses or final statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCode6Choice.Pending))]
    [KnownType(typeof(PaymentStatusCode6Choice.Final))]
    [KnownType(typeof(PaymentStatusCode6Choice.RTGS))]
    [KnownType(typeof(PaymentStatusCode6Choice.Settlement))]
    [KnownType(typeof(PaymentStatusCode6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentStatusCode6Choice.Pending),nameof(PaymentStatusCode6Choice.Pending))]
    [JsonDerivedType(typeof(PaymentStatusCode6Choice.Final),nameof(PaymentStatusCode6Choice.Final))]
    [JsonDerivedType(typeof(PaymentStatusCode6Choice.RTGS),nameof(PaymentStatusCode6Choice.RTGS))]
    [JsonDerivedType(typeof(PaymentStatusCode6Choice.Settlement),nameof(PaymentStatusCode6Choice.Settlement))]
    [JsonDerivedType(typeof(PaymentStatusCode6Choice.Proprietary),nameof(PaymentStatusCode6Choice.Proprietary))]
    #endif
    [IsoId("_pIXBKRbzEeOy-PlRuFSUzQ")]
    [DisplayName("Payment Status Code 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCode6Choice_
    #else
    public abstract partial class PaymentStatusCode6Choice_
    #endif
    {
    }
}
