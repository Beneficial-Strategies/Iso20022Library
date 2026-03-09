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
    [KnownType(typeof(PartyIdentification229Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification229Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification229Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification229Choice.IndividualOwnerIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification229Choice.AnyBIC),nameof(PartyIdentification229Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification229Choice.ProprietaryIdentification),nameof(PartyIdentification229Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification229Choice.NameAndAddress),nameof(PartyIdentification229Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification229Choice.IndividualOwnerIdentification),nameof(PartyIdentification229Choice.IndividualOwnerIdentification))]
    #endif
    [IsoId("_pblve-4CEeqc-LCjwLsUVg")]
    [DisplayName("Party Identification 229 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification229Choice_
    #else
    public abstract partial class PartyIdentification229Choice_
    #endif
    {
    }
}
