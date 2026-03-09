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
    [KnownType(typeof(TradeConfirmation1Choice.Confirmed))]
    [KnownType(typeof(TradeConfirmation1Choice.NonConfirmed))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeConfirmation1Choice.Confirmed),nameof(TradeConfirmation1Choice.Confirmed))]
    [JsonDerivedType(typeof(TradeConfirmation1Choice.NonConfirmed),nameof(TradeConfirmation1Choice.NonConfirmed))]
    #endif
    [IsoId("_L6EzwQ26EeWmAKKPnqYEVQ")]
    [DisplayName("Trade Confirmation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeConfirmation1Choice_
    #else
    public abstract partial class TradeConfirmation1Choice_
    #endif
    {
    }
}
