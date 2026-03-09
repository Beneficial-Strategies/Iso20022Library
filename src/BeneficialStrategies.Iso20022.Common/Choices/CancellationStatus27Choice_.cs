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
    [KnownType(typeof(CancellationStatus27Choice.GlobalCancellationStatus))]
    [KnownType(typeof(CancellationStatus27Choice.DetailedCancellationStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationStatus27Choice.GlobalCancellationStatus),nameof(CancellationStatus27Choice.GlobalCancellationStatus))]
    [JsonDerivedType(typeof(CancellationStatus27Choice.DetailedCancellationStatus),nameof(CancellationStatus27Choice.DetailedCancellationStatus))]
    #endif
    [IsoId("_xTJyQMT1Eem9aZlimxVUIw")]
    [DisplayName("Cancellation Status 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatus27Choice_
    #else
    public abstract partial class CancellationStatus27Choice_
    #endif
    {
    }
}
