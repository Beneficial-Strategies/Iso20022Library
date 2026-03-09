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
    /// Choice of formats for an identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification134Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification134Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification134Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification134Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification134Choice.AnyBIC),nameof(PartyIdentification134Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification134Choice.ProprietaryIdentification),nameof(PartyIdentification134Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification134Choice.NameAndAddress),nameof(PartyIdentification134Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification134Choice.Country),nameof(PartyIdentification134Choice.Country))]
    #endif
    [IsoId("_JGMJ1dXZEeiN28wlpBQScw")]
    [DisplayName("Party Identification 134 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification134Choice_
    #else
    public abstract partial class PartyIdentification134Choice_
    #endif
    {
    }
}
