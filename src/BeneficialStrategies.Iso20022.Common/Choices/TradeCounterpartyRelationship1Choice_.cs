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
    /// Specifies the relationship type between parties to the transaction.
    /// </summary>
    [KnownType(typeof(TradeCounterpartyRelationship1Choice.Code))]
    [KnownType(typeof(TradeCounterpartyRelationship1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeCounterpartyRelationship1Choice.Code),nameof(TradeCounterpartyRelationship1Choice.Code))]
    [JsonDerivedType(typeof(TradeCounterpartyRelationship1Choice.Proprietary),nameof(TradeCounterpartyRelationship1Choice.Proprietary))]
    #endif
    [IsoId("_n_k54Cb_Ee2BYL6XeAmCWw")]
    [DisplayName("Trade Counterparty Relationship 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeCounterpartyRelationship1Choice_
    #else
    public abstract partial class TradeCounterpartyRelationship1Choice_
    #endif
    {
    }
}
