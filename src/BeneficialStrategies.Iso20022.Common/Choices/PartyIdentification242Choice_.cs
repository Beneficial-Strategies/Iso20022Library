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
    /// Choice between a BIC, name and address or a LEI to identify a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification242Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification242Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification242Choice.PartyIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification242Choice.NameAndAddress),nameof(PartyIdentification242Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification242Choice.AnyBIC),nameof(PartyIdentification242Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification242Choice.PartyIdentification),nameof(PartyIdentification242Choice.PartyIdentification))]
    #endif
    [IsoId("_BSSs4QN1Ee2-vqzwMUAewg")]
    [DisplayName("Party Identification 242 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification242Choice_
    #else
    public abstract partial class PartyIdentification242Choice_
    #endif
    {
    }
}
