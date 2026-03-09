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
    [KnownType(typeof(Recipient11Choice.KeyTransport))]
    [KnownType(typeof(Recipient11Choice.KEK))]
    [KnownType(typeof(Recipient11Choice.KeyIdentifier))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Recipient11Choice.KeyTransport),nameof(Recipient11Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient11Choice.KEK),nameof(Recipient11Choice.KEK))]
    [JsonDerivedType(typeof(Recipient11Choice.KeyIdentifier),nameof(Recipient11Choice.KeyIdentifier))]
    #endif
    [IsoId("_6nK84VE0EeyApZmLzm74zA")]
    [DisplayName("Recipient 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Recipient11Choice_
    #else
    public abstract partial class Recipient11Choice_
    #endif
    {
    }
}
