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
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice47Choice.Code))]
    [KnownType(typeof(TypeOfPrice47Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TypeOfPrice47Choice.Code),nameof(TypeOfPrice47Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice47Choice.Proprietary),nameof(TypeOfPrice47Choice.Proprietary))]
    #endif
    [IsoId("_Pe1UEZBhEeakHoV5BVecAQ")]
    [DisplayName("Type Of Price 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TypeOfPrice47Choice_
    #else
    public abstract partial class TypeOfPrice47Choice_
    #endif
    {
    }
}
