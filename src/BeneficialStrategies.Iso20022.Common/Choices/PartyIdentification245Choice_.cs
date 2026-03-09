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
    [KnownType(typeof(PartyIdentification245Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification245Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification245Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification245Choice.AnyBIC),nameof(PartyIdentification245Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification245Choice.ProprietaryIdentification),nameof(PartyIdentification245Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification245Choice.NameAndAddress),nameof(PartyIdentification245Choice.NameAndAddress))]
    #endif
    [IsoId("_ZfQDSQauEe2phaVG0lYKTw")]
    [DisplayName("Party Identification 245 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification245Choice_
    #else
    public abstract partial class PartyIdentification245Choice_
    #endif
    {
    }
}
