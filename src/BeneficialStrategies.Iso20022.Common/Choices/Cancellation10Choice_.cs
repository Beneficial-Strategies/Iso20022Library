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
    [KnownType(typeof(Cancellation10Choice.References))]
    [KnownType(typeof(Cancellation10Choice.TransferInDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation10Choice.References),nameof(Cancellation10Choice.References))]
    [JsonDerivedType(typeof(Cancellation10Choice.TransferInDetails),nameof(Cancellation10Choice.TransferInDetails))]
    #endif
    [IsoId("_4rvp9yPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation10Choice_
    #else
    public abstract partial class Cancellation10Choice_
    #endif
    {
    }
}
