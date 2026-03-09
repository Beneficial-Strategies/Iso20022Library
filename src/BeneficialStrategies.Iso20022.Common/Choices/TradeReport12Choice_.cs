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
    /// Position/transaction reporting under EMIR regulation.
    /// </summary>
    [KnownType(typeof(TradeReport12Choice.Position))]
    [KnownType(typeof(TradeReport12Choice.Transaction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeReport12Choice.Position),nameof(TradeReport12Choice.Position))]
    [JsonDerivedType(typeof(TradeReport12Choice.Transaction),nameof(TradeReport12Choice.Transaction))]
    #endif
    [IsoId("_bPhuNxLBEeqctpBfTmLJnw")]
    [DisplayName("Trade Report 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReport12Choice_
    #else
    public abstract partial class TradeReport12Choice_
    #endif
    {
    }
}
