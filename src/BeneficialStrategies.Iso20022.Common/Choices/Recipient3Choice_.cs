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
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient3Choice.KeyTransport))]
    [KnownType(typeof(Recipient3Choice.KEK))]
    [KnownType(typeof(Recipient3Choice.KeyIdentifier))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Recipient3Choice.KeyTransport),nameof(Recipient3Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient3Choice.KEK),nameof(Recipient3Choice.KEK))]
    [JsonDerivedType(typeof(Recipient3Choice.KeyIdentifier),nameof(Recipient3Choice.KeyIdentifier))]
    #endif
    [IsoId("_k-l58S9eEeOlZIh7PImd0A")]
    [DisplayName("Recipient 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Recipient3Choice_
    #else
    public abstract partial class Recipient3Choice_
    #endif
    {
    }
}
