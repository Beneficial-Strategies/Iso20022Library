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
    [KnownType(typeof(PaymentStatusCode4Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCode4Choice.FinalStatus))]
    [KnownType(typeof(PaymentStatusCode4Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentStatusCode4Choice.PendingStatus),nameof(PaymentStatusCode4Choice.PendingStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode4Choice.FinalStatus),nameof(PaymentStatusCode4Choice.FinalStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode4Choice.ProprietaryStatus),nameof(PaymentStatusCode4Choice.ProprietaryStatus))]
    #endif
    [IsoId("_RZcdOtp-Ed-ak6NoX_4Aeg_1463454824")]
    [DisplayName("Payment Status Code 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCode4Choice_
    #else
    public abstract partial class PaymentStatusCode4Choice_
    #endif
    {
    }
}
