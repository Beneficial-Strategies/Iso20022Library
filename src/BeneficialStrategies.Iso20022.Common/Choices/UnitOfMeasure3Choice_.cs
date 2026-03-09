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
    /// Specifies a unit of measure with a code or free text.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure3Choice.UnitOfMeasureCode))]
    [KnownType(typeof(UnitOfMeasure3Choice.OtherUnitOfMeasure))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOfMeasure3Choice.UnitOfMeasureCode),nameof(UnitOfMeasure3Choice.UnitOfMeasureCode))]
    [JsonDerivedType(typeof(UnitOfMeasure3Choice.OtherUnitOfMeasure),nameof(UnitOfMeasure3Choice.OtherUnitOfMeasure))]
    #endif
    [IsoId("__YQFQBrZEeOVR9VN6fAMUg")]
    [DisplayName("Unit Of Measure 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOfMeasure3Choice_
    #else
    public abstract partial class UnitOfMeasure3Choice_
    #endif
    {
    }
}
