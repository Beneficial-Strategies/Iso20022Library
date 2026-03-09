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
    [KnownType(typeof(PartyIdentification137Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification137Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification137Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification137Choice.AnyBIC),nameof(PartyIdentification137Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification137Choice.ProprietaryIdentification),nameof(PartyIdentification137Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification137Choice.NameAndAddress),nameof(PartyIdentification137Choice.NameAndAddress))]
    #endif
    [IsoId("__2ajK_fDEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 137 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification137Choice_
    #else
    public abstract partial class PartyIdentification137Choice_
    #endif
    {
    }
}
