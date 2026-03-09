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
    /// Identifies various types of floating rates.
    /// </summary>
    [KnownType(typeof(FloatingRateIdentification8Choice.Code))]
    [KnownType(typeof(FloatingRateIdentification8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FloatingRateIdentification8Choice.Code),nameof(FloatingRateIdentification8Choice.Code))]
    [JsonDerivedType(typeof(FloatingRateIdentification8Choice.Proprietary),nameof(FloatingRateIdentification8Choice.Proprietary))]
    #endif
    [IsoId("_IrIB4TNoEe2UWZuK9pqFtg")]
    [DisplayName("Floating Rate Identification 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FloatingRateIdentification8Choice_
    #else
    public abstract partial class FloatingRateIdentification8Choice_
    #endif
    {
    }
}
