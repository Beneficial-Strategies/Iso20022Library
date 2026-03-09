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
    /// Choice of formats for the transaction-in type.
    /// </summary>
    [KnownType(typeof(InvestmentFundTransactionInType1Choice.Code))]
    [KnownType(typeof(InvestmentFundTransactionInType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestmentFundTransactionInType1Choice.Code),nameof(InvestmentFundTransactionInType1Choice.Code))]
    [JsonDerivedType(typeof(InvestmentFundTransactionInType1Choice.Proprietary),nameof(InvestmentFundTransactionInType1Choice.Proprietary))]
    #endif
    [IsoId("_SMsrUQaxEeS3lpTattq7hg")]
    [DisplayName("Investment Fund Transaction In Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestmentFundTransactionInType1Choice_
    #else
    public abstract partial class InvestmentFundTransactionInType1Choice_
    #endif
    {
    }
}
