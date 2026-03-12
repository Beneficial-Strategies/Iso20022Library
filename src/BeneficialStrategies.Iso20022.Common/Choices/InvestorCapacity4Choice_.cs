// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the investor capacity.
    /// </summary>
    [KnownType(typeof(InvestorCapacity4Choice.Code))]
    [KnownType(typeof(InvestorCapacity4Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorCapacity4Choice.Code),nameof(InvestorCapacity4Choice.Code))]
    [JsonDerivedType(typeof(InvestorCapacity4Choice.Proprietary),nameof(InvestorCapacity4Choice.Proprietary))]
    [IsoId("_0J3I8TtCEeWRTLSN0i0tng")]
    [DisplayName("Investor Capacity 4 Choice")]
    public abstract partial record InvestorCapacity4Choice_
    {
    }
}
