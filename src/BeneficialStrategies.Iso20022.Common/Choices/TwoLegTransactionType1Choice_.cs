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
    /// Specifies the choice of the two leg transaction type.
    /// </summary>
    [KnownType(typeof(TwoLegTransactionType1Choice.FutureOrOptionDetails))]
    [KnownType(typeof(TwoLegTransactionType1Choice.SecuritiesFinancingDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TwoLegTransactionType1Choice.FutureOrOptionDetails),nameof(TwoLegTransactionType1Choice.FutureOrOptionDetails))]
    [JsonDerivedType(typeof(TwoLegTransactionType1Choice.SecuritiesFinancingDetails),nameof(TwoLegTransactionType1Choice.SecuritiesFinancingDetails))]
    #endif
    [IsoId("_AYOINdokEeC60axPepSq7g_1757509328")]
    [DisplayName("Two Leg Transaction Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TwoLegTransactionType1Choice_
    #else
    public abstract partial class TwoLegTransactionType1Choice_
    #endif
    {
    }
}
