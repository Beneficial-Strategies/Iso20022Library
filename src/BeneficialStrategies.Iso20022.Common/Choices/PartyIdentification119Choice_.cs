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
    /// Choice between formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification119Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification119Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification119Choice.AnyBIC),nameof(PartyIdentification119Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification119Choice.ProprietaryIdentification),nameof(PartyIdentification119Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_T0GcgYipEeefvMoXmllHqg")]
    [DisplayName("Party Identification 119 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification119Choice_
    #else
    public abstract partial class PartyIdentification119Choice_
    #endif
    {
    }
}
