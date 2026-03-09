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
    [KnownType(typeof(Reversal4Choice.Reference))]
    [KnownType(typeof(Reversal4Choice.TransferInConfirmationDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reversal4Choice.Reference),nameof(Reversal4Choice.Reference))]
    [JsonDerivedType(typeof(Reversal4Choice.TransferInConfirmationDetails),nameof(Reversal4Choice.TransferInConfirmationDetails))]
    #endif
    [IsoId("_PslE0RX3EeOBE-jZfcm4KQ")]
    [DisplayName("Reversal 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversal4Choice_
    #else
    public abstract partial class Reversal4Choice_
    #endif
    {
    }
}
