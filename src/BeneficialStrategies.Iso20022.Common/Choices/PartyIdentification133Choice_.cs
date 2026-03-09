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
    /// Choice of formats for an identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification133Choice.BICFI))]
    [KnownType(typeof(PartyIdentification133Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification133Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification133Choice.BICFI),nameof(PartyIdentification133Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification133Choice.NameAndAddress),nameof(PartyIdentification133Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification133Choice.ProprietaryIdentification),nameof(PartyIdentification133Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_HoinrdXWEeiN28wlpBQScw")]
    [DisplayName("Party Identification 133 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification133Choice_
    #else
    public abstract partial class PartyIdentification133Choice_
    #endif
    {
    }
}
