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
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification100Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification100Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification100Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification100Choice.AnyBIC),nameof(PartyIdentification100Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification100Choice.ProprietaryIdentification),nameof(PartyIdentification100Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification100Choice.NameAndAddress),nameof(PartyIdentification100Choice.NameAndAddress))]
    #endif
    [IsoId("_vWZPoYFvEeWtPe6Crjmeug")]
    [DisplayName("Party Identification 100 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification100Choice_
    #else
    public abstract partial class PartyIdentification100Choice_
    #endif
    {
    }
}
