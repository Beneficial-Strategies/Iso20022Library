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
    [KnownType(typeof(PartyIdentification117Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification117Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification117Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification117Choice.AnyBIC),nameof(PartyIdentification117Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification117Choice.ProprietaryIdentification),nameof(PartyIdentification117Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification117Choice.NameAndAddress),nameof(PartyIdentification117Choice.NameAndAddress))]
    #endif
    [IsoId("_bJCCkZErEeakHoV5BVecAQ")]
    [DisplayName("Party Identification 117 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification117Choice_
    #else
    public abstract partial class PartyIdentification117Choice_
    #endif
    {
    }
}
