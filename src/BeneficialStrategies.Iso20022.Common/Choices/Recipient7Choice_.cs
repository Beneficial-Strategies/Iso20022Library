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
    [KnownType(typeof(Recipient7Choice.KeyTransport))]
    [KnownType(typeof(Recipient7Choice.KEK))]
    [KnownType(typeof(Recipient7Choice.KeyIdentifier))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Recipient7Choice.KeyTransport),nameof(Recipient7Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient7Choice.KEK),nameof(Recipient7Choice.KEK))]
    [JsonDerivedType(typeof(Recipient7Choice.KeyIdentifier),nameof(Recipient7Choice.KeyIdentifier))]
    #endif
    [IsoId("__A-bsaRbEeeWXKXf3KjtmQ")]
    [DisplayName("Recipient 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Recipient7Choice_
    #else
    public abstract partial class Recipient7Choice_
    #endif
    {
    }
}
