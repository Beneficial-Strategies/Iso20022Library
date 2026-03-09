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
    [KnownType(typeof(PartyIdentification205Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification205Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification205Choice.LegalPerson),nameof(PartyIdentification205Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification205Choice.NaturalPerson),nameof(PartyIdentification205Choice.NaturalPerson))]
    #endif
    [IsoId("_hQcS8I6XEemzmeK8_tPygg")]
    [DisplayName("Party Identification 205 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification205Choice_
    #else
    public abstract partial class PartyIdentification205Choice_
    #endif
    {
    }
}
