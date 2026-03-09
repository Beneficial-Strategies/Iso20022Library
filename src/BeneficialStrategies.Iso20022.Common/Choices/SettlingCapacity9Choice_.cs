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
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity9Choice.Code))]
    [KnownType(typeof(SettlingCapacity9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlingCapacity9Choice.Code),nameof(SettlingCapacity9Choice.Code))]
    [JsonDerivedType(typeof(SettlingCapacity9Choice.Proprietary),nameof(SettlingCapacity9Choice.Proprietary))]
    #endif
    [IsoId("_hOSOwZEZEeakHoV5BVecAQ")]
    [DisplayName("Settling Capacity 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlingCapacity9Choice_
    #else
    public abstract partial class SettlingCapacity9Choice_
    #endif
    {
    }
}
