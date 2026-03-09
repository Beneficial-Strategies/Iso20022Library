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
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio3Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio3Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio3Choice.Pension))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundPortfolio3Choice.TaxEfficientProduct),nameof(FundPortfolio3Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio3Choice.GeneralInvestment),nameof(FundPortfolio3Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio3Choice.Pension),nameof(FundPortfolio3Choice.Pension))]
    #endif
    [IsoId("_UorNQU7cEeifNrXGwadPmg")]
    [DisplayName("Fund Portfolio 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundPortfolio3Choice_
    #else
    public abstract partial class FundPortfolio3Choice_
    #endif
    {
    }
}
