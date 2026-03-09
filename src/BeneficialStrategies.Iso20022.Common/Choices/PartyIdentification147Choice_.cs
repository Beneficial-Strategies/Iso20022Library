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
    [KnownType(typeof(PartyIdentification147Choice.BICFI))]
    [KnownType(typeof(PartyIdentification147Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification147Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification147Choice.BICFI),nameof(PartyIdentification147Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification147Choice.NameAndAddress),nameof(PartyIdentification147Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification147Choice.ProprietaryIdentification),nameof(PartyIdentification147Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_8GnIGffREeiNZp_PtLohLw")]
    [DisplayName("Party Identification 147 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification147Choice_
    #else
    public abstract partial class PartyIdentification147Choice_
    #endif
    {
    }
}
