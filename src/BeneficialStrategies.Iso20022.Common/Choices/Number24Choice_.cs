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
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number24Choice.NumberIdentification))]
    [KnownType(typeof(Number24Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Number24Choice.NumberIdentification),nameof(Number24Choice.NumberIdentification))]
    [JsonDerivedType(typeof(Number24Choice.Proprietary),nameof(Number24Choice.Proprietary))]
    #endif
    [IsoId("_6OTyMZBfEeakHoV5BVecAQ")]
    [DisplayName("Number 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Number24Choice_
    #else
    public abstract partial class Number24Choice_
    #endif
    {
    }
}
