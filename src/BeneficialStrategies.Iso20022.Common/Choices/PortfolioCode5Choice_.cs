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
    [KnownType(typeof(PortfolioCode5Choice.Portfolio))]
    [KnownType(typeof(PortfolioCode5Choice.NoPortfolio))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PortfolioCode5Choice.Portfolio),nameof(PortfolioCode5Choice.Portfolio))]
    [JsonDerivedType(typeof(PortfolioCode5Choice.NoPortfolio),nameof(PortfolioCode5Choice.NoPortfolio))]
    #endif
    [IsoId("_wm77UTICEe2fXedS_ucFOA")]
    [DisplayName("Portfolio Code 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PortfolioCode5Choice_
    #else
    public abstract partial class PortfolioCode5Choice_
    #endif
    {
    }
}
