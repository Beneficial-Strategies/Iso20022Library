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
    /// Criteria for the trade venue identification.
    /// </summary>
    [KnownType(typeof(SecuritiesTradeVenueCriteria1Choice.MIC))]
    [KnownType(typeof(SecuritiesTradeVenueCriteria1Choice.AnyMIC))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTradeVenueCriteria1Choice.MIC),nameof(SecuritiesTradeVenueCriteria1Choice.MIC))]
    [JsonDerivedType(typeof(SecuritiesTradeVenueCriteria1Choice.AnyMIC),nameof(SecuritiesTradeVenueCriteria1Choice.AnyMIC))]
    #endif
    [IsoId("_a5LOAx3ZEeWNp95x0ENf8w")]
    [DisplayName("Securities Trade Venue Criteria 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTradeVenueCriteria1Choice_
    #else
    public abstract partial class SecuritiesTradeVenueCriteria1Choice_
    #endif
    {
    }
}
