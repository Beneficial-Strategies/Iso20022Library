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
    [KnownType(typeof(Reversal7Choice.Reference))]
    [KnownType(typeof(Reversal7Choice.TransferInConfirmationDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reversal7Choice.Reference),nameof(Reversal7Choice.Reference))]
    [JsonDerivedType(typeof(Reversal7Choice.TransferInConfirmationDetails),nameof(Reversal7Choice.TransferInConfirmationDetails))]
    #endif
    [IsoId("_23jIcCPvEeWQjryFgN2ITg")]
    [DisplayName("Reversal 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversal7Choice_
    #else
    public abstract partial class Reversal7Choice_
    #endif
    {
    }
}
