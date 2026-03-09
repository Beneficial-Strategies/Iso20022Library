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
    [KnownType(typeof(PartyIdentification226Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification226Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification226Choice.LegalPerson),nameof(PartyIdentification226Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification226Choice.NaturalPerson),nameof(PartyIdentification226Choice.NaturalPerson))]
    #endif
    [IsoId("_nbVCM6-kEemJ1NnLPsTFaw")]
    [DisplayName("Party Identification 226 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification226Choice_
    #else
    public abstract partial class PartyIdentification226Choice_
    #endif
    {
    }
}
