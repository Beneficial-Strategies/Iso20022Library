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
    /// Element is a choice between a known portfolio code and a code applicable when the code is unknown.
    /// </summary>
    [KnownType(typeof(PortfolioCode3Choice.Code))]
    [KnownType(typeof(PortfolioCode3Choice.NoPortfolio))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PortfolioCode3Choice.Code),nameof(PortfolioCode3Choice.Code))]
    [JsonDerivedType(typeof(PortfolioCode3Choice.NoPortfolio),nameof(PortfolioCode3Choice.NoPortfolio))]
    #endif
    [IsoId("_WMQcEVzGEeyTL-yEabFeNg")]
    [DisplayName("Portfolio Code 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PortfolioCode3Choice_
    #else
    public abstract partial class PortfolioCode3Choice_
    #endif
    {
    }
}
