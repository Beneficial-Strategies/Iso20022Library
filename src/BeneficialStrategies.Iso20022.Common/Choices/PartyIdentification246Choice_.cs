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
    [KnownType(typeof(PartyIdentification246Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification246Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification246Choice.LegalPerson),nameof(PartyIdentification246Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification246Choice.NaturalPerson),nameof(PartyIdentification246Choice.NaturalPerson))]
    #endif
    [IsoId("__6rlSzUCEe2tRf29bleifQ")]
    [DisplayName("Party Identification 246 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification246Choice_
    #else
    public abstract partial class PartyIdentification246Choice_
    #endif
    {
    }
}
