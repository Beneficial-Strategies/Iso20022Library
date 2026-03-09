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
    [KnownType(typeof(PartyIdentification95Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification95Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification95Choice.AnyBIC),nameof(PartyIdentification95Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification95Choice.ProprietaryIdentification),nameof(PartyIdentification95Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_VyhSAZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Party Identification 95 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification95Choice_
    #else
    public abstract partial class PartyIdentification95Choice_
    #endif
    {
    }
}
