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
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage6Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage6Choice.OtherReference))]
    [KnownType(typeof(LinkedMessage6Choice.RelatedReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LinkedMessage6Choice.PreviousReference),nameof(LinkedMessage6Choice.PreviousReference))]
    [JsonDerivedType(typeof(LinkedMessage6Choice.OtherReference),nameof(LinkedMessage6Choice.OtherReference))]
    [JsonDerivedType(typeof(LinkedMessage6Choice.RelatedReference),nameof(LinkedMessage6Choice.RelatedReference))]
    #endif
    [IsoId("_2mW56TWhEe2OzdGcZrUAEQ")]
    [DisplayName("Linked Message 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LinkedMessage6Choice_
    #else
    public abstract partial class LinkedMessage6Choice_
    #endif
    {
    }
}
