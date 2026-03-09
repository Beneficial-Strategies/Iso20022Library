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
    [KnownType(typeof(Cancellation7Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation7Choice.CancellationByReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation7Choice.CancellationByTransferInstructionDetails),nameof(Cancellation7Choice.CancellationByTransferInstructionDetails))]
    [JsonDerivedType(typeof(Cancellation7Choice.CancellationByReference),nameof(Cancellation7Choice.CancellationByReference))]
    #endif
    [IsoId("_lZHWSQgMEeSFYfyUKDXKaw")]
    [DisplayName("Cancellation 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation7Choice_
    #else
    public abstract partial class Cancellation7Choice_
    #endif
    {
    }
}
