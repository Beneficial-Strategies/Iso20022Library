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
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType41Choice.Code))]
    [KnownType(typeof(IdentificationType41Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationType41Choice.Code),nameof(IdentificationType41Choice.Code))]
    [JsonDerivedType(typeof(IdentificationType41Choice.Proprietary),nameof(IdentificationType41Choice.Proprietary))]
    #endif
    [IsoId("_VizA0NoqEeCWg-hsBVGrDA_-682466528")]
    [DisplayName("Identification Type 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationType41Choice_
    #else
    public abstract partial class IdentificationType41Choice_
    #endif
    {
    }
}
