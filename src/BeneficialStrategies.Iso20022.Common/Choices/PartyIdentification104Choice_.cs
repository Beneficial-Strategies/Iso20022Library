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
    [KnownType(typeof(PartyIdentification104Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification104Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification104Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification104Choice.AnyBIC),nameof(PartyIdentification104Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification104Choice.ProprietaryIdentification),nameof(PartyIdentification104Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification104Choice.NameAndAddress),nameof(PartyIdentification104Choice.NameAndAddress))]
    #endif
    [IsoId("_cdS3mZKQEeWHWpTQn1FFVg")]
    [DisplayName("Party Identification 104 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification104Choice_
    #else
    public abstract partial class PartyIdentification104Choice_
    #endif
    {
    }
}
