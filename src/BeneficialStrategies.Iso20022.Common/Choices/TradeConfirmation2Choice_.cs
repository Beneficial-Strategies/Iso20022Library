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
    [KnownType(typeof(TradeConfirmation2Choice.Confirmed))]
    [KnownType(typeof(TradeConfirmation2Choice.NonConfirmed))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeConfirmation2Choice.Confirmed),nameof(TradeConfirmation2Choice.Confirmed))]
    [JsonDerivedType(typeof(TradeConfirmation2Choice.NonConfirmed),nameof(TradeConfirmation2Choice.NonConfirmed))]
    #endif
    [IsoId("_qQg6EQFXEeaDfK-zDSyB6A")]
    [DisplayName("Trade Confirmation 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeConfirmation2Choice_
    #else
    public abstract partial class TradeConfirmation2Choice_
    #endif
    {
    }
}
