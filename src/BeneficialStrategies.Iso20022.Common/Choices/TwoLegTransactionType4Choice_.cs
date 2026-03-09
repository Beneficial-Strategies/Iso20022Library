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
    [KnownType(typeof(TwoLegTransactionType4Choice.FutureOrOptionDetails))]
    [KnownType(typeof(TwoLegTransactionType4Choice.SecuritiesFinancingDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TwoLegTransactionType4Choice.FutureOrOptionDetails),nameof(TwoLegTransactionType4Choice.FutureOrOptionDetails))]
    [JsonDerivedType(typeof(TwoLegTransactionType4Choice.SecuritiesFinancingDetails),nameof(TwoLegTransactionType4Choice.SecuritiesFinancingDetails))]
    #endif
    [IsoId("_854_sQhKEe2fOITqoTnSLQ")]
    [DisplayName("Two Leg Transaction Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TwoLegTransactionType4Choice_
    #else
    public abstract partial class TwoLegTransactionType4Choice_
    #endif
    {
    }
}
