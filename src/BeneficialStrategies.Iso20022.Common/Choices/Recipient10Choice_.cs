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
    [KnownType(typeof(Recipient10Choice.KeyTransport))]
    [KnownType(typeof(Recipient10Choice.KEK))]
    [KnownType(typeof(Recipient10Choice.KeyIdentifier))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Recipient10Choice.KeyTransport),nameof(Recipient10Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient10Choice.KEK),nameof(Recipient10Choice.KEK))]
    [JsonDerivedType(typeof(Recipient10Choice.KeyIdentifier),nameof(Recipient10Choice.KeyIdentifier))]
    #endif
    [IsoId("_Wl_KAS8jEeu125Ip9zFcsQ")]
    [DisplayName("Recipient 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Recipient10Choice_
    #else
    public abstract partial class Recipient10Choice_
    #endif
    {
    }
}
