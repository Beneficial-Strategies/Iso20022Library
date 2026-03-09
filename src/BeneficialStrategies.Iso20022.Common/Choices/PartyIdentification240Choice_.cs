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
    [KnownType(typeof(PartyIdentification240Choice.BIC))]
    [KnownType(typeof(PartyIdentification240Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification240Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification240Choice.BIC),nameof(PartyIdentification240Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification240Choice.ProprietaryIdentification),nameof(PartyIdentification240Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification240Choice.NameAndAddress),nameof(PartyIdentification240Choice.NameAndAddress))]
    #endif
    [IsoId("_mF6ywStKEeyOa655cLd-DQ")]
    [DisplayName("Party Identification 240 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification240Choice_
    #else
    public abstract partial class PartyIdentification240Choice_
    #endif
    {
    }
}
