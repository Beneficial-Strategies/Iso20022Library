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
    /// Choice of formats for the commission basis.
    /// </summary>
    [KnownType(typeof(CommissionBasis1Choice.Code))]
    [KnownType(typeof(CommissionBasis1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommissionBasis1Choice.Code),nameof(CommissionBasis1Choice.Code))]
    [JsonDerivedType(typeof(CommissionBasis1Choice.Proprietary),nameof(CommissionBasis1Choice.Proprietary))]
    #endif
    [IsoId("_LgZzgRuCEeOqSdXzJ0oydA")]
    [DisplayName("Commission Basis 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommissionBasis1Choice_
    #else
    public abstract partial class CommissionBasis1Choice_
    #endif
    {
    }
}
