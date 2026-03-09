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
    [KnownType(typeof(PaymentStatusCode3Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCode3Choice.FinalStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentStatusCode3Choice.PendingStatus),nameof(PaymentStatusCode3Choice.PendingStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode3Choice.FinalStatus),nameof(PaymentStatusCode3Choice.FinalStatus))]
    #endif
    [IsoId("_RF7ER9p-Ed-ak6NoX_4Aeg_2006585714")]
    [DisplayName("Payment Status Code 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCode3Choice_
    #else
    public abstract partial class PaymentStatusCode3Choice_
    #endif
    {
    }
}
