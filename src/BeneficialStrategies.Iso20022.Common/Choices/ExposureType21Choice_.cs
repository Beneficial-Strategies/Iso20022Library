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
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [KnownType(typeof(ExposureType21Choice.Code))]
    [KnownType(typeof(ExposureType21Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExposureType21Choice.Code),nameof(ExposureType21Choice.Code))]
    [JsonDerivedType(typeof(ExposureType21Choice.Proprietary),nameof(ExposureType21Choice.Proprietary))]
    #endif
    [IsoId("_17rh4SW1EeyT3chuyX0PgA")]
    [DisplayName("Exposure Type 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExposureType21Choice_
    #else
    public abstract partial class ExposureType21Choice_
    #endif
    {
    }
}
