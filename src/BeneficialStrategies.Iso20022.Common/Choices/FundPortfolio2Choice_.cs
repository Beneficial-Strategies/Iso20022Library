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
    [KnownType(typeof(FundPortfolio2Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio2Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio2Choice.Pension))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundPortfolio2Choice.TaxEfficientProduct),nameof(FundPortfolio2Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio2Choice.GeneralInvestment),nameof(FundPortfolio2Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio2Choice.Pension),nameof(FundPortfolio2Choice.Pension))]
    #endif
    [IsoId("_ozJ3sU4aEeiQHa-q1Uephw")]
    [DisplayName("Fund Portfolio 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundPortfolio2Choice_
    #else
    public abstract partial class FundPortfolio2Choice_
    #endif
    {
    }
}
