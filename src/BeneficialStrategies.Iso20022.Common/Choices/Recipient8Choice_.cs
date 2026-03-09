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
    [KnownType(typeof(Recipient8Choice.KeyTransport))]
    [KnownType(typeof(Recipient8Choice.KEK))]
    [KnownType(typeof(Recipient8Choice.KeyIdentifier))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Recipient8Choice.KeyTransport),nameof(Recipient8Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient8Choice.KEK),nameof(Recipient8Choice.KEK))]
    [JsonDerivedType(typeof(Recipient8Choice.KeyIdentifier),nameof(Recipient8Choice.KeyIdentifier))]
    #endif
    [IsoId("_D5gIcQxqEeqdx6buGpCCQw")]
    [DisplayName("Recipient 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Recipient8Choice_
    #else
    public abstract partial class Recipient8Choice_
    #endif
    {
    }
}
