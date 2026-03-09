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
    /// Choice of formats for the transaction-out type.
    /// </summary>
    [KnownType(typeof(InvestmentFundTransactionOutType1Choice.Code))]
    [KnownType(typeof(InvestmentFundTransactionOutType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestmentFundTransactionOutType1Choice.Code),nameof(InvestmentFundTransactionOutType1Choice.Code))]
    [JsonDerivedType(typeof(InvestmentFundTransactionOutType1Choice.Proprietary),nameof(InvestmentFundTransactionOutType1Choice.Proprietary))]
    #endif
    [IsoId("_SxyAcRMJEeSopak1K45eVQ")]
    [DisplayName("Investment Fund Transaction Out Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestmentFundTransactionOutType1Choice_
    #else
    public abstract partial class InvestmentFundTransactionOutType1Choice_
    #endif
    {
    }
}
