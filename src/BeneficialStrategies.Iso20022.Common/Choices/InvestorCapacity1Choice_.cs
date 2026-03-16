// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the investor capacity.
    /// </summary>
    [KnownType(typeof(InvestorCapacity1Choice.Code))]
    [KnownType(typeof(InvestorCapacity1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorCapacity1Choice.Code), nameof(InvestorCapacity1Choice.Code))]
    [JsonDerivedType(
        typeof(InvestorCapacity1Choice.Proprietary),
        nameof(InvestorCapacity1Choice.Proprietary)
    )]
    [IsoId("_QsvIN9p-Ed-ak6NoX_4Aeg_-1479062235")]
    [DisplayName("Investor Capacity 1 Choice")]
    public abstract record InvestorCapacity1Choice_ { }
}
