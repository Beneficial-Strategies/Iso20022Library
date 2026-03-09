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
    /// Choice of cash purpose or a securities market identifier.
    /// </summary>
    [KnownType(typeof(MarketIdentificationOrCashPurpose1Choice.SettlementInstructionMarketIdentification))]
    [KnownType(typeof(MarketIdentificationOrCashPurpose1Choice.CashSSIPurpose))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketIdentificationOrCashPurpose1Choice.SettlementInstructionMarketIdentification),nameof(MarketIdentificationOrCashPurpose1Choice.SettlementInstructionMarketIdentification))]
    [JsonDerivedType(typeof(MarketIdentificationOrCashPurpose1Choice.CashSSIPurpose),nameof(MarketIdentificationOrCashPurpose1Choice.CashSSIPurpose))]
    #endif
    [IsoId("_Lc9dQEiNEeOdL6nMHefDgg")]
    [DisplayName("Market Identification Or Cash Purpose 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketIdentificationOrCashPurpose1Choice_
    #else
    public abstract partial class MarketIdentificationOrCashPurpose1Choice_
    #endif
    {
    }
}
