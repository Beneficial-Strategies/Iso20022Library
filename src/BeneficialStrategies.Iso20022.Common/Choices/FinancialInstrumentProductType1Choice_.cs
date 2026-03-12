// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to indicate the type of product the financial instrument is associated with (used for fixed income).
    /// </summary>
    [KnownType(typeof(FinancialInstrumentProductType1Choice.Code))]
    [KnownType(typeof(FinancialInstrumentProductType1Choice.Proprietary))]
    [JsonDerivedType(typeof(FinancialInstrumentProductType1Choice.Code),nameof(FinancialInstrumentProductType1Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentProductType1Choice.Proprietary),nameof(FinancialInstrumentProductType1Choice.Proprietary))]
    [IsoId("_TuJqx9p-Ed-ak6NoX_4Aeg_1973024995")]
    [DisplayName("Financial Instrument Product Type 1 Choice")]
    public abstract partial record FinancialInstrumentProductType1Choice_
    {
    }
}
