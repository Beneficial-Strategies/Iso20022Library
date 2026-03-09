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
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification236Choice.Legal))]
    [KnownType(typeof(PartyIdentification236Choice.Natural))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification236Choice.Legal),nameof(PartyIdentification236Choice.Legal))]
    [JsonDerivedType(typeof(PartyIdentification236Choice.Natural),nameof(PartyIdentification236Choice.Natural))]
    #endif
    [IsoId("_bOmisMgoEeuGrNSsxk3B0A")]
    [DisplayName("Party Identification 236 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification236Choice_
    #else
    public abstract partial class PartyIdentification236Choice_
    #endif
    {
    }
}
