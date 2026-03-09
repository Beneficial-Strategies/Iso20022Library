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
    [KnownType(typeof(PartyIdentification152Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification152Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification152Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification152Choice.AnyBIC),nameof(PartyIdentification152Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification152Choice.ProprietaryIdentification),nameof(PartyIdentification152Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification152Choice.NameAndAddress),nameof(PartyIdentification152Choice.NameAndAddress))]
    #endif
    [IsoId("_2vSTQf1REeixXcHVEYIW2g")]
    [DisplayName("Party Identification 152 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification152Choice_
    #else
    public abstract partial class PartyIdentification152Choice_
    #endif
    {
    }
}
