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
    /// Choice between a code and a data source scheme to specify the type of natural person identification.
    /// </summary>
    [KnownType(typeof(IdentificationType45Choice.Code))]
    [KnownType(typeof(IdentificationType45Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationType45Choice.Code),nameof(IdentificationType45Choice.Code))]
    [JsonDerivedType(typeof(IdentificationType45Choice.Proprietary),nameof(IdentificationType45Choice.Proprietary))]
    #endif
    [IsoId("_ql4v0Id6EemJ1cSJJmVYRQ")]
    [DisplayName("Identification Type 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationType45Choice_
    #else
    public abstract partial class IdentificationType45Choice_
    #endif
    {
    }
}
