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
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification90Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification90Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification90Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification90Choice.AnyBIC),nameof(PartyIdentification90Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification90Choice.ProprietaryIdentification),nameof(PartyIdentification90Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification90Choice.NameAndAddress),nameof(PartyIdentification90Choice.NameAndAddress))]
    #endif
    [IsoId("_Fo7rqdedEeSA_uUacqhl1Q")]
    [DisplayName("Party Identification 90 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification90Choice_
    #else
    public abstract partial class PartyIdentification90Choice_
    #endif
    {
    }
}
