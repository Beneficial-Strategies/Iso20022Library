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
    /// Characteristics of the goods that are certified, in the context of a commercial trade transaction.
    /// </summary>
    [KnownType(typeof(CertifiedCharacteristics2Choice.Origin))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Quality))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Analysis))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Weight))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.Quantity))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.HealthIndication))]
    [KnownType(typeof(CertifiedCharacteristics2Choice.PhytosanitaryIndication))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CertifiedCharacteristics2Choice.Origin),nameof(CertifiedCharacteristics2Choice.Origin))]
    [JsonDerivedType(typeof(CertifiedCharacteristics2Choice.Quality),nameof(CertifiedCharacteristics2Choice.Quality))]
    [JsonDerivedType(typeof(CertifiedCharacteristics2Choice.Analysis),nameof(CertifiedCharacteristics2Choice.Analysis))]
    [JsonDerivedType(typeof(CertifiedCharacteristics2Choice.Weight),nameof(CertifiedCharacteristics2Choice.Weight))]
    [JsonDerivedType(typeof(CertifiedCharacteristics2Choice.Quantity),nameof(CertifiedCharacteristics2Choice.Quantity))]
    [JsonDerivedType(typeof(CertifiedCharacteristics2Choice.HealthIndication),nameof(CertifiedCharacteristics2Choice.HealthIndication))]
    [JsonDerivedType(typeof(CertifiedCharacteristics2Choice.PhytosanitaryIndication),nameof(CertifiedCharacteristics2Choice.PhytosanitaryIndication))]
    #endif
    [IsoId("_2nTCgTANEeOKib24wnHaFg")]
    [DisplayName("Certified Characteristics 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CertifiedCharacteristics2Choice_
    #else
    public abstract partial class CertifiedCharacteristics2Choice_
    #endif
    {
    }
}
