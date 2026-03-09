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
    /// Choice of formats for the price type.
    /// </summary>
    [KnownType(typeof(UnitPriceType2Choice.Code))]
    [KnownType(typeof(UnitPriceType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitPriceType2Choice.Code),nameof(UnitPriceType2Choice.Code))]
    [JsonDerivedType(typeof(UnitPriceType2Choice.Proprietary),nameof(UnitPriceType2Choice.Proprietary))]
    #endif
    [IsoId("_N23jAQc_EeSyIPzOZ6VzBQ")]
    [DisplayName("Unit Price Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitPriceType2Choice_
    #else
    public abstract partial class UnitPriceType2Choice_
    #endif
    {
    }
}
