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
    /// Choice of formats for the ex-post cost calculation basis.
    /// </summary>
    [KnownType(typeof(ExPostCostCalculationBasis1Choice.Code))]
    [KnownType(typeof(ExPostCostCalculationBasis1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExPostCostCalculationBasis1Choice.Code),nameof(ExPostCostCalculationBasis1Choice.Code))]
    [JsonDerivedType(typeof(ExPostCostCalculationBasis1Choice.Proprietary),nameof(ExPostCostCalculationBasis1Choice.Proprietary))]
    #endif
    [IsoId("_Wb5bQJ9XEeqxTNfi5y7ywQ")]
    [DisplayName("Ex Post Cost Calculation Basis 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExPostCostCalculationBasis1Choice_
    #else
    public abstract partial class ExPostCostCalculationBasis1Choice_
    #endif
    {
    }
}
