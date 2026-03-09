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
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification234Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification234Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification234Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification234Choice.IndividualOwnerIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification234Choice.AnyBIC),nameof(PartyIdentification234Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification234Choice.ProprietaryIdentification),nameof(PartyIdentification234Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification234Choice.NameAndAddress),nameof(PartyIdentification234Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification234Choice.IndividualOwnerIdentification),nameof(PartyIdentification234Choice.IndividualOwnerIdentification))]
    #endif
    [IsoId("_F-iyMR9REeuFz_FaCzCLgQ")]
    [DisplayName("Party Identification 234 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification234Choice_
    #else
    public abstract partial class PartyIdentification234Choice_
    #endif
    {
    }
}
