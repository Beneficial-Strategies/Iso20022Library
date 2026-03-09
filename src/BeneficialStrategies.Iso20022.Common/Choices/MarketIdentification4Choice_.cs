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
    /// Choice of market identification.
    /// </summary>
    [KnownType(typeof(MarketIdentification4Choice.MarketIdentifierCode))]
    [KnownType(typeof(MarketIdentification4Choice.Description))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketIdentification4Choice.MarketIdentifierCode),nameof(MarketIdentification4Choice.MarketIdentifierCode))]
    [JsonDerivedType(typeof(MarketIdentification4Choice.Description),nameof(MarketIdentification4Choice.Description))]
    #endif
    [IsoId("_04BcYQk_EeGQpPnjvNlciw")]
    [DisplayName("Market Identification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketIdentification4Choice_
    #else
    public abstract partial class MarketIdentification4Choice_
    #endif
    {
    }
}
