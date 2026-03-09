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
    /// Choice between formats for a type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType6Choice.Code))]
    [KnownType(typeof(ChargeType6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeType6Choice.Code),nameof(ChargeType6Choice.Code))]
    [JsonDerivedType(typeof(ChargeType6Choice.Proprietary),nameof(ChargeType6Choice.Proprietary))]
    #endif
    [IsoId("_h-65cYjKEeeqaMoyJI1HbA")]
    [DisplayName("Charge Type 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType6Choice_
    #else
    public abstract partial class ChargeType6Choice_
    #endif
    {
    }
}
