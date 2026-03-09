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
    [KnownType(typeof(PartyIdentification121Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification121Choice.LegalEntityIdentifier))]
    [KnownType(typeof(PartyIdentification121Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification121Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification121Choice.AnyBIC),nameof(PartyIdentification121Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification121Choice.LegalEntityIdentifier),nameof(PartyIdentification121Choice.LegalEntityIdentifier))]
    [JsonDerivedType(typeof(PartyIdentification121Choice.NameAndAddress),nameof(PartyIdentification121Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification121Choice.ProprietaryIdentification),nameof(PartyIdentification121Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_c7VdkJQVEeiok48Eh9lW9Q")]
    [DisplayName("Party Identification 121 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification121Choice_
    #else
    public abstract partial class PartyIdentification121Choice_
    #endif
    {
    }
}
