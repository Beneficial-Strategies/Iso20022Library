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
    /// Choice of calculation basis type.
    /// </summary>
    [KnownType(typeof(TaxCalculationBasisType1Choice.Basis))]
    [KnownType(typeof(TaxCalculationBasisType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxCalculationBasisType1Choice.Basis),nameof(TaxCalculationBasisType1Choice.Basis))]
    [JsonDerivedType(typeof(TaxCalculationBasisType1Choice.Proprietary),nameof(TaxCalculationBasisType1Choice.Proprietary))]
    #endif
    [IsoId("_RfQKRdp-Ed-ak6NoX_4Aeg_-1842013319")]
    [DisplayName("Tax Calculation Basis Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCalculationBasisType1Choice_
    #else
    public abstract partial class TaxCalculationBasisType1Choice_
    #endif
    {
    }
}
