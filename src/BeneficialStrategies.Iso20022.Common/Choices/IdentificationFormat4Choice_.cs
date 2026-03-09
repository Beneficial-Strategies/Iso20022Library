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
    /// Choice between either a short, long or a proprietary identification format.
    /// </summary>
    [KnownType(typeof(IdentificationFormat4Choice.ShortIdentification))]
    [KnownType(typeof(IdentificationFormat4Choice.LongIdentification))]
    [KnownType(typeof(IdentificationFormat4Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationFormat4Choice.ShortIdentification),nameof(IdentificationFormat4Choice.ShortIdentification))]
    [JsonDerivedType(typeof(IdentificationFormat4Choice.LongIdentification),nameof(IdentificationFormat4Choice.LongIdentification))]
    [JsonDerivedType(typeof(IdentificationFormat4Choice.ProprietaryIdentification),nameof(IdentificationFormat4Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_c5VTNZKQEeWHWpTQn1FFVg")]
    [DisplayName("Identification Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationFormat4Choice_
    #else
    public abstract partial class IdentificationFormat4Choice_
    #endif
    {
    }
}
