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
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification177Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification177Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification177Choice.AnyBIC),nameof(PartyIdentification177Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification177Choice.ProprietaryIdentification),nameof(PartyIdentification177Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_7X5zsdgvEeipBO1pkKK6zg")]
    [DisplayName("Party Identification 177 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification177Choice_
    #else
    public abstract partial class PartyIdentification177Choice_
    #endif
    {
    }
}
