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
    /// Provides the status of an instruction.
    /// </summary>
    [KnownType(typeof(ProcessingStatus82Choice.Processed))]
    [KnownType(typeof(ProcessingStatus82Choice.Future))]
    [KnownType(typeof(ProcessingStatus82Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus82Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus82Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus82Choice.CancellationRequest))]
    [KnownType(typeof(ProcessingStatus82Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Processed),nameof(ProcessingStatus82Choice.Processed))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Future),nameof(ProcessingStatus82Choice.Future))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Rejected),nameof(ProcessingStatus82Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Cancelled),nameof(ProcessingStatus82Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.PendingCancellation),nameof(ProcessingStatus82Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.CancellationRequest),nameof(ProcessingStatus82Choice.CancellationRequest))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Proprietary),nameof(ProcessingStatus82Choice.Proprietary))]
    #endif
    [IsoId("_FNlTwRIwEeydmIVkS03esw")]
    [DisplayName("Processing Status 82 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus82Choice_
    #else
    public abstract partial class ProcessingStatus82Choice_
    #endif
    {
    }
}
