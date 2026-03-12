// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the category of investment account.
    /// </summary>
    [KnownType(typeof(InvestmentAccountCategory1Choice.Code))]
    [KnownType(typeof(InvestmentAccountCategory1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestmentAccountCategory1Choice.Code),nameof(InvestmentAccountCategory1Choice.Code))]
    [JsonDerivedType(typeof(InvestmentAccountCategory1Choice.Proprietary),nameof(InvestmentAccountCategory1Choice.Proprietary))]
    [IsoId("_SqpDQRRIEeOKWo1NF21OVw")]
    [DisplayName("Investment Account Category 1 Choice")]
    public abstract partial record InvestmentAccountCategory1Choice_
    {
    }
}
