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
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation12Choice.References))]
    [KnownType(typeof(Cancellation12Choice.TransferOutDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation12Choice.References),nameof(Cancellation12Choice.References))]
    [JsonDerivedType(typeof(Cancellation12Choice.TransferOutDetails),nameof(Cancellation12Choice.TransferOutDetails))]
    #endif
    [IsoId("__8PcLSPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation12Choice_
    #else
    public abstract partial class Cancellation12Choice_
    #endif
    {
    }
}
