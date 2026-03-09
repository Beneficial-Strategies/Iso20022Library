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
    [KnownType(typeof(Cancellation3Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation3Choice.CancellationByReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation3Choice.CancellationByTransferInstructionDetails),nameof(Cancellation3Choice.CancellationByTransferInstructionDetails))]
    [JsonDerivedType(typeof(Cancellation3Choice.CancellationByReference),nameof(Cancellation3Choice.CancellationByReference))]
    #endif
    [IsoId("_uMEusycZEeK33eWt3gq4Fg")]
    [DisplayName("Cancellation 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation3Choice_
    #else
    public abstract partial class Cancellation3Choice_
    #endif
    {
    }
}
