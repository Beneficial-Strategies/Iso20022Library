// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the investment account type.
    /// </summary>
    [KnownType(typeof(InvestmentAccountType1Choice.Code))]
    [KnownType(typeof(InvestmentAccountType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestmentAccountType1Choice.Code),nameof(InvestmentAccountType1Choice.Code))]
    [JsonDerivedType(typeof(InvestmentAccountType1Choice.Proprietary),nameof(InvestmentAccountType1Choice.Proprietary))]
    [IsoId("_C6GQ4xdLEeK5g-3oYI0_9Q")]
    [DisplayName("Investment Account Type 1 Choice")]
    public abstract partial record InvestmentAccountType1Choice_
    {
    }
}
