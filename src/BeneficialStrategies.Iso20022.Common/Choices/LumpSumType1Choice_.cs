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
    /// Choice of formats for a type of lump sum.
    /// </summary>
    [KnownType(typeof(LumpSumType1Choice.Code))]
    [KnownType(typeof(LumpSumType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LumpSumType1Choice.Code),nameof(LumpSumType1Choice.Code))]
    [JsonDerivedType(typeof(LumpSumType1Choice.Proprietary),nameof(LumpSumType1Choice.Proprietary))]
    #endif
    [IsoId("_AB4QYLKdEeiXL6Ccd-oU8g")]
    [DisplayName("Lump Sum Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LumpSumType1Choice_
    #else
    public abstract partial class LumpSumType1Choice_
    #endif
    {
    }
}
