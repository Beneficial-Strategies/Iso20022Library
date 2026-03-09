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
    /// Choice of format for unit of measure.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure4Choice.Code))]
    [KnownType(typeof(UnitOfMeasure4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOfMeasure4Choice.Code),nameof(UnitOfMeasure4Choice.Code))]
    [JsonDerivedType(typeof(UnitOfMeasure4Choice.Proprietary),nameof(UnitOfMeasure4Choice.Proprietary))]
    #endif
    [IsoId("_eda0K-LaEeWFtOV72FbX9w")]
    [DisplayName("Unit Of Measure 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOfMeasure4Choice_
    #else
    public abstract partial class UnitOfMeasure4Choice_
    #endif
    {
    }
}
