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
    /// Choice of formats for the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType3Choice.Code))]
    [KnownType(typeof(CommissionType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommissionType3Choice.Code),nameof(CommissionType3Choice.Code))]
    [JsonDerivedType(typeof(CommissionType3Choice.Proprietary),nameof(CommissionType3Choice.Proprietary))]
    #endif
    [IsoId("_92zmwRuAEeOqSdXzJ0oydA")]
    [DisplayName("Commission Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommissionType3Choice_
    #else
    public abstract partial class CommissionType3Choice_
    #endif
    {
    }
}
