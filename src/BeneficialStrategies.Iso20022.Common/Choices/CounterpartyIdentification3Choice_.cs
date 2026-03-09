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
    /// Provides the identification of the reporting agent counterparty.
    /// </summary>
    [KnownType(typeof(CounterpartyIdentification3Choice.LEI))]
    [KnownType(typeof(CounterpartyIdentification3Choice.SectorAndLocation))]
    [KnownType(typeof(CounterpartyIdentification3Choice.NameAndLocation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CounterpartyIdentification3Choice.LEI),nameof(CounterpartyIdentification3Choice.LEI))]
    [JsonDerivedType(typeof(CounterpartyIdentification3Choice.SectorAndLocation),nameof(CounterpartyIdentification3Choice.SectorAndLocation))]
    [JsonDerivedType(typeof(CounterpartyIdentification3Choice.NameAndLocation),nameof(CounterpartyIdentification3Choice.NameAndLocation))]
    #endif
    [IsoId("_Zo-9QcEcEea7jLfvGi1PDw")]
    [DisplayName("Counterparty Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyIdentification3Choice_
    #else
    public abstract partial class CounterpartyIdentification3Choice_
    #endif
    {
    }
}
