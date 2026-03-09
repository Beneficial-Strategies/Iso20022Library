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
    [KnownType(typeof(PartyIdentification45Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification45Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification45Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification45Choice.AnyBIC),nameof(PartyIdentification45Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification45Choice.ProprietaryIdentification),nameof(PartyIdentification45Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification45Choice.NameAndAddress),nameof(PartyIdentification45Choice.NameAndAddress))]
    #endif
    [IsoId("_idS_seaOEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification45Choice_
    #else
    public abstract partial class PartyIdentification45Choice_
    #endif
    {
    }
}
