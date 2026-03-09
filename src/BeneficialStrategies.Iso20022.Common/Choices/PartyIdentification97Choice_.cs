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
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification97Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification97Choice.LegalEntityIdentifier))]
    [KnownType(typeof(PartyIdentification97Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification97Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification97Choice.AnyBIC),nameof(PartyIdentification97Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification97Choice.LegalEntityIdentifier),nameof(PartyIdentification97Choice.LegalEntityIdentifier))]
    [JsonDerivedType(typeof(PartyIdentification97Choice.NameAndAddress),nameof(PartyIdentification97Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification97Choice.ProprietaryIdentification),nameof(PartyIdentification97Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_P50eUSVJEeWI0orciOKunQ")]
    [DisplayName("Party Identification 97 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification97Choice_
    #else
    public abstract partial class PartyIdentification97Choice_
    #endif
    {
    }
}
