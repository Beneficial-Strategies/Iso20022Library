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
    [KnownType(typeof(References63Choice.PreviousReference))]
    [KnownType(typeof(References63Choice.OtherReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References63Choice.PreviousReference),nameof(References63Choice.PreviousReference))]
    [JsonDerivedType(typeof(References63Choice.OtherReference),nameof(References63Choice.OtherReference))]
    #endif
    [IsoId("_buTXIYiiEeefvMoXmllHqg")]
    [DisplayName("References 63 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References63Choice_
    #else
    public abstract partial class References63Choice_
    #endif
    {
    }
}
