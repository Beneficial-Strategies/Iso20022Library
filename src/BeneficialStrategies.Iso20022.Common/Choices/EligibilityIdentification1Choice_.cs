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
    /// Specifies the eligibility details.
    /// </summary>
    [KnownType(typeof(EligibilityIdentification1Choice.Country))]
    [KnownType(typeof(EligibilityIdentification1Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(EligibilityIdentification1Choice.IssuerCSDIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EligibilityIdentification1Choice.Country),nameof(EligibilityIdentification1Choice.Country))]
    [JsonDerivedType(typeof(EligibilityIdentification1Choice.FinancialInstrumentIdentification),nameof(EligibilityIdentification1Choice.FinancialInstrumentIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification1Choice.IssuerCSDIdentification),nameof(EligibilityIdentification1Choice.IssuerCSDIdentification))]
    #endif
    [IsoId("_jBJ_8u5NEeCisYr99QEiWA_59531621")]
    [DisplayName("Eligibility Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EligibilityIdentification1Choice_
    #else
    public abstract partial class EligibilityIdentification1Choice_
    #endif
    {
    }
}
