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
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal8Choice.References))]
    [KnownType(typeof(Reversal8Choice.TransferOutConfirmationDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reversal8Choice.References),nameof(Reversal8Choice.References))]
    [JsonDerivedType(typeof(Reversal8Choice.TransferOutConfirmationDetails),nameof(Reversal8Choice.TransferOutConfirmationDetails))]
    #endif
    [IsoId("_9pFttyPvEeWQjryFgN2ITg")]
    [DisplayName("Reversal 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversal8Choice_
    #else
    public abstract partial class Reversal8Choice_
    #endif
    {
    }
}
