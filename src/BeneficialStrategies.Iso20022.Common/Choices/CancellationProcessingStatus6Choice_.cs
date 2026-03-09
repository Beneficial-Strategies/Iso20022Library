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
    [KnownType(typeof(CancellationProcessingStatus6Choice.CancellationPending))]
    [KnownType(typeof(CancellationProcessingStatus6Choice.CancellationRequested))]
    [KnownType(typeof(CancellationProcessingStatus6Choice.CancellationCompleted))]
    [KnownType(typeof(CancellationProcessingStatus6Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationProcessingStatus6Choice.CancellationPending),nameof(CancellationProcessingStatus6Choice.CancellationPending))]
    [JsonDerivedType(typeof(CancellationProcessingStatus6Choice.CancellationRequested),nameof(CancellationProcessingStatus6Choice.CancellationRequested))]
    [JsonDerivedType(typeof(CancellationProcessingStatus6Choice.CancellationCompleted),nameof(CancellationProcessingStatus6Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(CancellationProcessingStatus6Choice.ProprietaryStatus),nameof(CancellationProcessingStatus6Choice.ProprietaryStatus))]
    #endif
    [IsoId("_A4HJMtokEeC60axPepSq7g_1947058911")]
    [DisplayName("Cancellation Processing Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationProcessingStatus6Choice_
    #else
    public abstract partial class CancellationProcessingStatus6Choice_
    #endif
    {
    }
}
