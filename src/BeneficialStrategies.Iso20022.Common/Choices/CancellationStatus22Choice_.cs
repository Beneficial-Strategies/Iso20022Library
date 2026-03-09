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
    /// Status is cancelled.
    /// </summary>
    [KnownType(typeof(CancellationStatus22Choice.Status))]
    [KnownType(typeof(CancellationStatus22Choice.Rejected))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationStatus22Choice.Status),nameof(CancellationStatus22Choice.Status))]
    [JsonDerivedType(typeof(CancellationStatus22Choice.Rejected),nameof(CancellationStatus22Choice.Rejected))]
    #endif
    [IsoId("_kZs-EEgsEeaD2L_hzZaE0w")]
    [DisplayName("Cancellation Status 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatus22Choice_
    #else
    public abstract partial class CancellationStatus22Choice_
    #endif
    {
    }
}
