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
    /// Choice of identification of a party. The party can be identified by providing a BIC or a MIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification11Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification11Choice.CentralCounterparty))]
    [KnownType(typeof(PartyIdentification11Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification11Choice.BICOrBEI),nameof(PartyIdentification11Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification11Choice.CentralCounterparty),nameof(PartyIdentification11Choice.CentralCounterparty))]
    [JsonDerivedType(typeof(PartyIdentification11Choice.ProprietaryIdentification),nameof(PartyIdentification11Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_QReIh9p-Ed-ak6NoX_4Aeg_-60481643")]
    [DisplayName("Party Identification 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification11Choice_
    #else
    public abstract partial class PartyIdentification11Choice_
    #endif
    {
    }
}
