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
    [KnownType(typeof(Reversal6Choice.Reference))]
    [KnownType(typeof(Reversal6Choice.TransferInConfirmationDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reversal6Choice.Reference),nameof(Reversal6Choice.Reference))]
    [JsonDerivedType(typeof(Reversal6Choice.TransferInConfirmationDetails),nameof(Reversal6Choice.TransferInConfirmationDetails))]
    #endif
    [IsoId("_f7k5oT8BEeSIqOPJHpnleA")]
    [DisplayName("Reversal 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversal6Choice_
    #else
    public abstract partial class Reversal6Choice_
    #endif
    {
    }
}
