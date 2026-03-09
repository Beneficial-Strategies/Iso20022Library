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
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure8Choice.Code))]
    [KnownType(typeof(UnitOfMeasure8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOfMeasure8Choice.Code),nameof(UnitOfMeasure8Choice.Code))]
    [JsonDerivedType(typeof(UnitOfMeasure8Choice.Proprietary),nameof(UnitOfMeasure8Choice.Proprietary))]
    #endif
    [IsoId("_D7l4ADNlEe2UWZuK9pqFtg")]
    [DisplayName("Unit Of Measure 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOfMeasure8Choice_
    #else
    public abstract partial class UnitOfMeasure8Choice_
    #endif
    {
    }
}
