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
    [KnownType(typeof(PartyIdentification71Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification71Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification71Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification71Choice.AnyBIC),nameof(PartyIdentification71Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification71Choice.ProprietaryIdentification),nameof(PartyIdentification71Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification71Choice.NameAndAddress),nameof(PartyIdentification71Choice.NameAndAddress))]
    #endif
    [IsoId("_jLJCYe5NEeCisYr99QEiWA_-835354834")]
    [DisplayName("Party Identification 71 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification71Choice_
    #else
    public abstract partial class PartyIdentification71Choice_
    #endif
    {
    }
}
