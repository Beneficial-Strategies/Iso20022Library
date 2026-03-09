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
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType17Choice.Code))]
    [KnownType(typeof(MarketType17Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketType17Choice.Code),nameof(MarketType17Choice.Code))]
    [JsonDerivedType(typeof(MarketType17Choice.Proprietary),nameof(MarketType17Choice.Proprietary))]
    #endif
    [IsoId("_5W2zCZNLEeWGlc8L7oPDIg")]
    [DisplayName("Market Type 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketType17Choice_
    #else
    public abstract partial class MarketType17Choice_
    #endif
    {
    }
}
