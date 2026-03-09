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
    [KnownType(typeof(PartyIdentification43Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification43Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification43Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification43Choice.AnyBIC),nameof(PartyIdentification43Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification43Choice.ProprietaryIdentification),nameof(PartyIdentification43Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification43Choice.NameAndAddress),nameof(PartyIdentification43Choice.NameAndAddress))]
    #endif
    [IsoId("_eadcW-aOEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification43Choice_
    #else
    public abstract partial class PartyIdentification43Choice_
    #endif
    {
    }
}
