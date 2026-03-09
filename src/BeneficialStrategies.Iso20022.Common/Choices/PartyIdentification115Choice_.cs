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
    [KnownType(typeof(PartyIdentification115Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification115Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification115Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification115Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification115Choice.AnyBIC),nameof(PartyIdentification115Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification115Choice.ProprietaryIdentification),nameof(PartyIdentification115Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification115Choice.NameAndAddress),nameof(PartyIdentification115Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification115Choice.Country),nameof(PartyIdentification115Choice.Country))]
    #endif
    [IsoId("_SXTaEZjcEeWn2ur3BXxtdg")]
    [DisplayName("Party Identification 115 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification115Choice_
    #else
    public abstract partial class PartyIdentification115Choice_
    #endif
    {
    }
}
