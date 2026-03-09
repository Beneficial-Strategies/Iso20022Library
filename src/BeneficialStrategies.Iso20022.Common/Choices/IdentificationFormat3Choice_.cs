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
    [KnownType(typeof(IdentificationFormat3Choice.ShortIdentification))]
    [KnownType(typeof(IdentificationFormat3Choice.LongIdentification))]
    [KnownType(typeof(IdentificationFormat3Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationFormat3Choice.ShortIdentification),nameof(IdentificationFormat3Choice.ShortIdentification))]
    [JsonDerivedType(typeof(IdentificationFormat3Choice.LongIdentification),nameof(IdentificationFormat3Choice.LongIdentification))]
    [JsonDerivedType(typeof(IdentificationFormat3Choice.ProprietaryIdentification),nameof(IdentificationFormat3Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_qZTHkUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Identification Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationFormat3Choice_
    #else
    public abstract partial class IdentificationFormat3Choice_
    #endif
    {
    }
}
