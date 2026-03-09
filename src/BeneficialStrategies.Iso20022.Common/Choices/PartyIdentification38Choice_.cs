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
    [KnownType(typeof(PartyIdentification38Choice.BICFI))]
    [KnownType(typeof(PartyIdentification38Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification38Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification38Choice.BICFI),nameof(PartyIdentification38Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification38Choice.NameAndAddress),nameof(PartyIdentification38Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification38Choice.ProprietaryIdentification),nameof(PartyIdentification38Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_6VaZX-aQEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification38Choice_
    #else
    public abstract partial class PartyIdentification38Choice_
    #endif
    {
    }
}
