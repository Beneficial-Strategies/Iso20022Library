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
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument1Choice.Security))]
    [KnownType(typeof(FinancialInstrument1Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument1Choice.OtherAsset))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrument1Choice.Security),nameof(FinancialInstrument1Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument1Choice.CashAsset),nameof(FinancialInstrument1Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument1Choice.OtherAsset),nameof(FinancialInstrument1Choice.OtherAsset))]
    #endif
    [IsoId("_pCApoEyGEeir2sRRVd9XhA")]
    [DisplayName("Financial Instrument 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrument1Choice_
    #else
    public abstract partial class FinancialInstrument1Choice_
    #endif
    {
    }
}
