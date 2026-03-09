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
    /// Choice of status for the cancellation processing.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus10Choice.CancellationPending))]
    [KnownType(typeof(CancellationProcessingStatus10Choice.CancellationRequested))]
    [KnownType(typeof(CancellationProcessingStatus10Choice.CancellationCompleted))]
    [KnownType(typeof(CancellationProcessingStatus10Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.CancellationPending),nameof(CancellationProcessingStatus10Choice.CancellationPending))]
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.CancellationRequested),nameof(CancellationProcessingStatus10Choice.CancellationRequested))]
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.CancellationCompleted),nameof(CancellationProcessingStatus10Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.ProprietaryStatus),nameof(CancellationProcessingStatus10Choice.ProprietaryStatus))]
    #endif
    [IsoId("_livbgQd4Ee2fOITqoTnSLQ")]
    [DisplayName("Cancellation Processing Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationProcessingStatus10Choice_
    #else
    public abstract partial class CancellationProcessingStatus10Choice_
    #endif
    {
    }
}
