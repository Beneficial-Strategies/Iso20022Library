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
    [KnownType(typeof(CounterpartyIdentification1Choice.LEI))]
    [KnownType(typeof(CounterpartyIdentification1Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CounterpartyIdentification1Choice.LEI),nameof(CounterpartyIdentification1Choice.LEI))]
    [JsonDerivedType(typeof(CounterpartyIdentification1Choice.Other),nameof(CounterpartyIdentification1Choice.Other))]
    #endif
    [IsoId("_wlfJ0JfcEeSfnc-VXAEapg")]
    [DisplayName("Counterparty Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyIdentification1Choice_
    #else
    public abstract partial class CounterpartyIdentification1Choice_
    #endif
    {
    }
}
