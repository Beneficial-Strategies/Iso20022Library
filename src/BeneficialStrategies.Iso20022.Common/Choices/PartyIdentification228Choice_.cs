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
    [KnownType(typeof(PartyIdentification228Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification228Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification228Choice.LegalPerson),nameof(PartyIdentification228Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification228Choice.NaturalPerson),nameof(PartyIdentification228Choice.NaturalPerson))]
    #endif
    [IsoId("_3Ep6w7IFEemux5trsZcCpw")]
    [DisplayName("Party Identification 228 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification228Choice_
    #else
    public abstract partial class PartyIdentification228Choice_
    #endif
    {
    }
}
