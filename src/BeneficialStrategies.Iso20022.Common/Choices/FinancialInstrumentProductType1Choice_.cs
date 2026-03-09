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
    /// Choice between a code and a data source scheme to indicate the type of product the financial instrument is associated with (used for fixed income).
    /// </summary>
    [KnownType(typeof(FinancialInstrumentProductType1Choice.Code))]
    [KnownType(typeof(FinancialInstrumentProductType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentProductType1Choice.Code),nameof(FinancialInstrumentProductType1Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentProductType1Choice.Proprietary),nameof(FinancialInstrumentProductType1Choice.Proprietary))]
    #endif
    [IsoId("_TuJqx9p-Ed-ak6NoX_4Aeg_1973024995")]
    [DisplayName("Financial Instrument Product Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentProductType1Choice_
    #else
    public abstract partial class FinancialInstrumentProductType1Choice_
    #endif
    {
    }
}
