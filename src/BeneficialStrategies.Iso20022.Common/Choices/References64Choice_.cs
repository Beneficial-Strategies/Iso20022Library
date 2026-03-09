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
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References64Choice.RelatedReference))]
    [KnownType(typeof(References64Choice.OtherReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References64Choice.RelatedReference),nameof(References64Choice.RelatedReference))]
    [JsonDerivedType(typeof(References64Choice.OtherReference),nameof(References64Choice.OtherReference))]
    #endif
    [IsoId("_5f_BEWpYEeipaMTLlhaKMQ")]
    [DisplayName("References 64 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References64Choice_
    #else
    public abstract partial class References64Choice_
    #endif
    {
    }
}
