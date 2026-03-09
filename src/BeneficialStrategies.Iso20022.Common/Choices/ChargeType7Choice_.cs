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
    /// Choice of formats for a type of cost or charge.
    /// </summary>
    [KnownType(typeof(ChargeType7Choice.Code))]
    [KnownType(typeof(ChargeType7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeType7Choice.Code),nameof(ChargeType7Choice.Code))]
    [JsonDerivedType(typeof(ChargeType7Choice.Proprietary),nameof(ChargeType7Choice.Proprietary))]
    #endif
    [IsoId("_tM9ZIDcnEeidBoT_PugKiA")]
    [DisplayName("Charge Type 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType7Choice_
    #else
    public abstract partial class ChargeType7Choice_
    #endif
    {
    }
}
