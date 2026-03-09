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
    [KnownType(typeof(FundPortfolio6Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio6Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio6Choice.Pension))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundPortfolio6Choice.TaxEfficientProduct),nameof(FundPortfolio6Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio6Choice.GeneralInvestment),nameof(FundPortfolio6Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio6Choice.Pension),nameof(FundPortfolio6Choice.Pension))]
    #endif
    [IsoId("_1TpcAZNMEemQB_8XA98K0Q")]
    [DisplayName("Fund Portfolio 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundPortfolio6Choice_
    #else
    public abstract partial class FundPortfolio6Choice_
    #endif
    {
    }
}
