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
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification203Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification203Choice.LEI))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification203Choice.ProprietaryIdentification),nameof(PartyIdentification203Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification203Choice.LEI),nameof(PartyIdentification203Choice.LEI))]
    #endif
    [IsoId("_N8PiUFSXEempisJfoIfvvQ")]
    [DisplayName("Party Identification 203 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification203Choice_
    #else
    public abstract partial class PartyIdentification203Choice_
    #endif
    {
    }
}
