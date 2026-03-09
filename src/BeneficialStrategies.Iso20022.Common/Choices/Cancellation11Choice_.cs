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
    /// Choice between cancellation by transfer details or reference.
    /// </summary>
    [KnownType(typeof(Cancellation11Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation11Choice.CancellationByReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation11Choice.CancellationByTransferInstructionDetails),nameof(Cancellation11Choice.CancellationByTransferInstructionDetails))]
    [JsonDerivedType(typeof(Cancellation11Choice.CancellationByReference),nameof(Cancellation11Choice.CancellationByReference))]
    #endif
    [IsoId("_8SMzVSPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation11Choice_
    #else
    public abstract partial class Cancellation11Choice_
    #endif
    {
    }
}
