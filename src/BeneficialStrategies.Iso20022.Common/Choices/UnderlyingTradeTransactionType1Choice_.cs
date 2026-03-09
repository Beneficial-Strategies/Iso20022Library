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
    /// Choice of format for the commercial contract type.
    /// </summary>
    [KnownType(typeof(UnderlyingTradeTransactionType1Choice.Code))]
    [KnownType(typeof(UnderlyingTradeTransactionType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingTradeTransactionType1Choice.Code),nameof(UnderlyingTradeTransactionType1Choice.Code))]
    [JsonDerivedType(typeof(UnderlyingTradeTransactionType1Choice.Proprietary),nameof(UnderlyingTradeTransactionType1Choice.Proprietary))]
    #endif
    [IsoId("_93QOw3ltEeG7BsjMvd1mEw_-521905675")]
    [DisplayName("Underlying Trade Transaction Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingTradeTransactionType1Choice_
    #else
    public abstract partial class UnderlyingTradeTransactionType1Choice_
    #endif
    {
    }
}
