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
    /// Choice of formats for a type of investment plan.
    /// </summary>
    [KnownType(typeof(InvestmentFundPlanType1Choice.Code))]
    [KnownType(typeof(InvestmentFundPlanType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestmentFundPlanType1Choice.Code),nameof(InvestmentFundPlanType1Choice.Code))]
    [JsonDerivedType(typeof(InvestmentFundPlanType1Choice.Proprietary),nameof(InvestmentFundPlanType1Choice.Proprietary))]
    #endif
    [IsoId("_UxNjoF9CEeicg40_9gK9vQ")]
    [DisplayName("Investment Fund Plan Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestmentFundPlanType1Choice_
    #else
    public abstract partial class InvestmentFundPlanType1Choice_
    #endif
    {
    }
}
