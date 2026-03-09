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
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide7Choice.Code))]
    [KnownType(typeof(MarketClientSide7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketClientSide7Choice.Code),nameof(MarketClientSide7Choice.Code))]
    [JsonDerivedType(typeof(MarketClientSide7Choice.Proprietary),nameof(MarketClientSide7Choice.Proprietary))]
    #endif
    [IsoId("_5TtVXc3yEee5nJBZsW8MFQ")]
    [DisplayName("Market Client Side 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketClientSide7Choice_
    #else
    public abstract partial class MarketClientSide7Choice_
    #endif
    {
    }
}
