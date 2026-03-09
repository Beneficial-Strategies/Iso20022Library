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
    [KnownType(typeof(Cancellation6Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation6Choice.CancellationByReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation6Choice.CancellationByTransferInstructionDetails),nameof(Cancellation6Choice.CancellationByTransferInstructionDetails))]
    [JsonDerivedType(typeof(Cancellation6Choice.CancellationByReference),nameof(Cancellation6Choice.CancellationByReference))]
    #endif
    [IsoId("_rcvlURwnEeOIveEnnb_1-A")]
    [DisplayName("Cancellation 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation6Choice_
    #else
    public abstract partial class Cancellation6Choice_
    #endif
    {
    }
}
