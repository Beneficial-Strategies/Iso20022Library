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
    /// Choice between references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References68Choice.PreviousReference))]
    [KnownType(typeof(References68Choice.OtherReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References68Choice.PreviousReference),nameof(References68Choice.PreviousReference))]
    [JsonDerivedType(typeof(References68Choice.OtherReference),nameof(References68Choice.OtherReference))]
    #endif
    [IsoId("_HBeuoZGrEem-9Y6mq5ZH3Q")]
    [DisplayName("References 68 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References68Choice_
    #else
    public abstract partial class References68Choice_
    #endif
    {
    }
}
