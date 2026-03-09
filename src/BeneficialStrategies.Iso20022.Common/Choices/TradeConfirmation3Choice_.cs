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
    /// Information regarding the confirmation of the contract.
    /// </summary>
    [KnownType(typeof(TradeConfirmation3Choice.Confirmed))]
    [KnownType(typeof(TradeConfirmation3Choice.NonConfirmed))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeConfirmation3Choice.Confirmed),nameof(TradeConfirmation3Choice.Confirmed))]
    [JsonDerivedType(typeof(TradeConfirmation3Choice.NonConfirmed),nameof(TradeConfirmation3Choice.NonConfirmed))]
    #endif
    [IsoId("_POyMsVo3Ee23K4GXSpBSeg")]
    [DisplayName("Trade Confirmation 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeConfirmation3Choice_
    #else
    public abstract partial class TradeConfirmation3Choice_
    #endif
    {
    }
}
