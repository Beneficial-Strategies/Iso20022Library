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
    [KnownType(typeof(FundPortfolio5Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio5Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio5Choice.Pension))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundPortfolio5Choice.TaxEfficientProduct),nameof(FundPortfolio5Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio5Choice.GeneralInvestment),nameof(FundPortfolio5Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio5Choice.Pension),nameof(FundPortfolio5Choice.Pension))]
    #endif
    [IsoId("_nbBfUZNMEemQB_8XA98K0Q")]
    [DisplayName("Fund Portfolio 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundPortfolio5Choice_
    #else
    public abstract partial class FundPortfolio5Choice_
    #endif
    {
    }
}
