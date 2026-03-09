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
    /// Instruction/Request has been cancelled.
    /// </summary>
    [KnownType(typeof(CancellationStatus30Choice.Cancelled))]
    [KnownType(typeof(CancellationStatus30Choice.Processed))]
    [KnownType(typeof(CancellationStatus30Choice.Pending))]
    [KnownType(typeof(CancellationStatus30Choice.Rejected))]
    [KnownType(typeof(CancellationStatus30Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationStatus30Choice.Cancelled),nameof(CancellationStatus30Choice.Cancelled))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Processed),nameof(CancellationStatus30Choice.Processed))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Pending),nameof(CancellationStatus30Choice.Pending))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Rejected),nameof(CancellationStatus30Choice.Rejected))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Proprietary),nameof(CancellationStatus30Choice.Proprietary))]
    #endif
    [IsoId("_TpwpcRIwEeydmIVkS03esw")]
    [DisplayName("Cancellation Status 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatus30Choice_
    #else
    public abstract partial class CancellationStatus30Choice_
    #endif
    {
    }
}
