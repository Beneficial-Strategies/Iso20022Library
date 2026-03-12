// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the investment account and the financial instrument.
    /// </summary>
    [KnownType(typeof(InvestmentAccountOrFinancialInstrument1Choice.InvestmentAccount))]
    [KnownType(typeof(InvestmentAccountOrFinancialInstrument1Choice.FinancialInstrument))]
    [JsonDerivedType(typeof(InvestmentAccountOrFinancialInstrument1Choice.InvestmentAccount),nameof(InvestmentAccountOrFinancialInstrument1Choice.InvestmentAccount))]
    [JsonDerivedType(typeof(InvestmentAccountOrFinancialInstrument1Choice.FinancialInstrument),nameof(InvestmentAccountOrFinancialInstrument1Choice.FinancialInstrument))]
    [IsoId("_UuOns9p-Ed-ak6NoX_4Aeg_-1126591105")]
    [DisplayName("Investment Account Or Financial Instrument 1 Choice")]
    public abstract partial record InvestmentAccountOrFinancialInstrument1Choice_
    {
    }
}
