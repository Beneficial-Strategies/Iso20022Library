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
    [KnownType(typeof(PartyIdentification233Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification233Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification233Choice.LegalPerson),nameof(PartyIdentification233Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification233Choice.NaturalPerson),nameof(PartyIdentification233Choice.NaturalPerson))]
    #endif
    [IsoId("_6264AfQ0EeqAradXpAelDQ")]
    [DisplayName("Party Identification 233 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification233Choice_
    #else
    public abstract partial class PartyIdentification233Choice_
    #endif
    {
    }
}
