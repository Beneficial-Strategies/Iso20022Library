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
    [KnownType(typeof(PartyIdentification176Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification176Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification176Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification176Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification176Choice.AnyBIC),nameof(PartyIdentification176Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification176Choice.ProprietaryIdentification),nameof(PartyIdentification176Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification176Choice.NameAndAddress),nameof(PartyIdentification176Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification176Choice.Country),nameof(PartyIdentification176Choice.Country))]
    #endif
    [IsoId("_43Snp_fWEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 176 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification176Choice_
    #else
    public abstract partial class PartyIdentification176Choice_
    #endif
    {
    }
}
