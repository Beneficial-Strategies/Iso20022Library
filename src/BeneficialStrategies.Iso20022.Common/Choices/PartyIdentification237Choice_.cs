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
    [KnownType(typeof(PartyIdentification237Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification237Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification237Choice.LegalPerson),nameof(PartyIdentification237Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification237Choice.NaturalPerson),nameof(PartyIdentification237Choice.NaturalPerson))]
    #endif
    [IsoId("_fV47ERuUEeyhRdHRjakS2w")]
    [DisplayName("Party Identification 237 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification237Choice_
    #else
    public abstract partial class PartyIdentification237Choice_
    #endif
    {
    }
}
