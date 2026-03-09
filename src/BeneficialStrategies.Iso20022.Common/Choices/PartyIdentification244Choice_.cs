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
    [KnownType(typeof(PartyIdentification244Choice.BIC))]
    [KnownType(typeof(PartyIdentification244Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification244Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification244Choice.BIC),nameof(PartyIdentification244Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification244Choice.NameAndAddress),nameof(PartyIdentification244Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification244Choice.Country),nameof(PartyIdentification244Choice.Country))]
    #endif
    [IsoId("_IP93bQavEe2phaVG0lYKTw")]
    [DisplayName("Party Identification 244 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification244Choice_
    #else
    public abstract partial class PartyIdentification244Choice_
    #endif
    {
    }
}
