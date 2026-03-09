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
    [KnownType(typeof(PaymentStatusCode5Choice.Pending))]
    [KnownType(typeof(PaymentStatusCode5Choice.Final))]
    [KnownType(typeof(PaymentStatusCode5Choice.RTGS))]
    [KnownType(typeof(PaymentStatusCode5Choice.Settlement))]
    [KnownType(typeof(PaymentStatusCode5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentStatusCode5Choice.Pending),nameof(PaymentStatusCode5Choice.Pending))]
    [JsonDerivedType(typeof(PaymentStatusCode5Choice.Final),nameof(PaymentStatusCode5Choice.Final))]
    [JsonDerivedType(typeof(PaymentStatusCode5Choice.RTGS),nameof(PaymentStatusCode5Choice.RTGS))]
    [JsonDerivedType(typeof(PaymentStatusCode5Choice.Settlement),nameof(PaymentStatusCode5Choice.Settlement))]
    [JsonDerivedType(typeof(PaymentStatusCode5Choice.Proprietary),nameof(PaymentStatusCode5Choice.Proprietary))]
    #endif
    [IsoId("_72FYEqMgEeCJ6YNENx4h-w_2022583428")]
    [DisplayName("Payment Status Code 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCode5Choice_
    #else
    public abstract partial class PaymentStatusCode5Choice_
    #endif
    {
    }
}
