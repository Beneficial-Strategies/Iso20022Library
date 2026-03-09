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
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus26Choice.ProcessingStatus))]
    [KnownType(typeof(CancellationStatus26Choice.Rejected))]
    [KnownType(typeof(CancellationStatus26Choice.PendingCancellation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationStatus26Choice.ProcessingStatus),nameof(CancellationStatus26Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(CancellationStatus26Choice.Rejected),nameof(CancellationStatus26Choice.Rejected))]
    [JsonDerivedType(typeof(CancellationStatus26Choice.PendingCancellation),nameof(CancellationStatus26Choice.PendingCancellation))]
    #endif
    [IsoId("_iKIapLKfEemux5trsZcCpw")]
    [DisplayName("Cancellation Status 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatus26Choice_
    #else
    public abstract partial class CancellationStatus26Choice_
    #endif
    {
    }
}
