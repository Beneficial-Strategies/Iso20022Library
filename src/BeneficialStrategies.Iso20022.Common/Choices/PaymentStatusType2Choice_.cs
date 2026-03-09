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
    /// Indicates the status of the payment, either as a raw status, or as a detailed status.
    /// </summary>
    [KnownType(typeof(PaymentStatusType2Choice.RawStatus))]
    [KnownType(typeof(PaymentStatusType2Choice.DetailedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentStatusType2Choice.RawStatus),nameof(PaymentStatusType2Choice.RawStatus))]
    [JsonDerivedType(typeof(PaymentStatusType2Choice.DetailedStatus),nameof(PaymentStatusType2Choice.DetailedStatus))]
    #endif
    [IsoId("_CuMfQSYMEei7VPGVFTQkxA")]
    [DisplayName("Payment Status Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusType2Choice_
    #else
    public abstract partial class PaymentStatusType2Choice_
    #endif
    {
    }
}
