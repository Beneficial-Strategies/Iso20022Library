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
    /// Choice of formats for the specification of the type of insurance.
    /// </summary>
    [KnownType(typeof(InsuranceType1Choice.Code))]
    [KnownType(typeof(InsuranceType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InsuranceType1Choice.Code),nameof(InsuranceType1Choice.Code))]
    [JsonDerivedType(typeof(InsuranceType1Choice.Proprietary),nameof(InsuranceType1Choice.Proprietary))]
    #endif
    [IsoId("_ckqDQBQZEeKebsB9eKJSkA")]
    [DisplayName("Insurance Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InsuranceType1Choice_
    #else
    public abstract partial class InsuranceType1Choice_
    #endif
    {
    }
}
