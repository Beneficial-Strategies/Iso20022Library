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
    [KnownType(typeof(FundPortfolio7Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio7Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio7Choice.Pension))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundPortfolio7Choice.TaxEfficientProduct),nameof(FundPortfolio7Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio7Choice.GeneralInvestment),nameof(FundPortfolio7Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio7Choice.Pension),nameof(FundPortfolio7Choice.Pension))]
    #endif
    [IsoId("_Xn1_oelfEeu9cf4XM82AQQ")]
    [DisplayName("Fund Portfolio 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundPortfolio7Choice_
    #else
    public abstract partial class FundPortfolio7Choice_
    #endif
    {
    }
}
