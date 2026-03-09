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
    [KnownType(typeof(MarketIdentification2Choice.MarketIdentifierCode))]
    [KnownType(typeof(MarketIdentification2Choice.Description))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketIdentification2Choice.MarketIdentifierCode),nameof(MarketIdentification2Choice.MarketIdentifierCode))]
    [JsonDerivedType(typeof(MarketIdentification2Choice.Description),nameof(MarketIdentification2Choice.Description))]
    #endif
    [IsoId("_XK10ENp-Ed-ak6NoX_4Aeg_-180703514")]
    [DisplayName("Market Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketIdentification2Choice_
    #else
    public abstract partial class MarketIdentification2Choice_
    #endif
    {
    }
}
