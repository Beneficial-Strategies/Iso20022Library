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
    [KnownType(typeof(FundPortfolio4Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio4Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio4Choice.Pension))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundPortfolio4Choice.TaxEfficientProduct),nameof(FundPortfolio4Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio4Choice.GeneralInvestment),nameof(FundPortfolio4Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio4Choice.Pension),nameof(FundPortfolio4Choice.Pension))]
    #endif
    [IsoId("_U3qR0ZNMEemQB_8XA98K0Q")]
    [DisplayName("Fund Portfolio 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundPortfolio4Choice_
    #else
    public abstract partial class FundPortfolio4Choice_
    #endif
    {
    }
}
