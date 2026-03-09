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
    [KnownType(typeof(PartyIdentification196Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification196Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification196Choice.LegalPerson),nameof(PartyIdentification196Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification196Choice.NaturalPerson),nameof(PartyIdentification196Choice.NaturalPerson))]
    #endif
    [IsoId("_3xRQ4zqrEemL_ewJY9QP1g")]
    [DisplayName("Party Identification 196 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification196Choice_
    #else
    public abstract partial class PartyIdentification196Choice_
    #endif
    {
    }
}
