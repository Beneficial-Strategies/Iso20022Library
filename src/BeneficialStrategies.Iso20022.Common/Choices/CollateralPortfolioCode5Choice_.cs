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
    /// Specifies the unique codes identifying the portfolio.
    /// </summary>
    [KnownType(typeof(CollateralPortfolioCode5Choice.Portfolio))]
    [KnownType(typeof(CollateralPortfolioCode5Choice.MarginPortfolioCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralPortfolioCode5Choice.Portfolio),nameof(CollateralPortfolioCode5Choice.Portfolio))]
    [JsonDerivedType(typeof(CollateralPortfolioCode5Choice.MarginPortfolioCode),nameof(CollateralPortfolioCode5Choice.MarginPortfolioCode))]
    #endif
    [IsoId("_YwE-cTIDEe2fXedS_ucFOA")]
    [DisplayName("Collateral Portfolio Code 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralPortfolioCode5Choice_
    #else
    public abstract partial class CollateralPortfolioCode5Choice_
    #endif
    {
    }
}
