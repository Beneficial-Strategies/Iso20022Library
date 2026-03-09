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
    /// Specifies a unit of measure.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure5Choice.Code))]
    [KnownType(typeof(UnitOfMeasure5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOfMeasure5Choice.Code),nameof(UnitOfMeasure5Choice.Code))]
    [JsonDerivedType(typeof(UnitOfMeasure5Choice.Proprietary),nameof(UnitOfMeasure5Choice.Proprietary))]
    #endif
    [IsoId("_arSvUPp2EeaQh_7a05rSJQ")]
    [DisplayName("Unit Of Measure 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOfMeasure5Choice_
    #else
    public abstract partial class UnitOfMeasure5Choice_
    #endif
    {
    }
}
