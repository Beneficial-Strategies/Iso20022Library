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
    [KnownType(typeof(PartyIdentification227Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification227Choice.NaturalPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification227Choice.LegalPerson),nameof(PartyIdentification227Choice.LegalPerson))]
    [JsonDerivedType(typeof(PartyIdentification227Choice.NaturalPerson),nameof(PartyIdentification227Choice.NaturalPerson))]
    #endif
    [IsoId("_B1TxM6-mEemJ1NnLPsTFaw")]
    [DisplayName("Party Identification 227 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification227Choice_
    #else
    public abstract partial class PartyIdentification227Choice_
    #endif
    {
    }
}
