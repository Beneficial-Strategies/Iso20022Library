// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType13Choice.Code))]
    [KnownType(typeof(SubBalanceType13Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType13Choice.Code),nameof(SubBalanceType13Choice.Code))]
    [JsonDerivedType(typeof(SubBalanceType13Choice.Proprietary),nameof(SubBalanceType13Choice.Proprietary))]
    [IsoId("_5W5195NLEeWGlc8L7oPDIg")]
    [DisplayName("Sub Balance Type 13 Choice")]
    public abstract partial record SubBalanceType13Choice_
    {
    }
}
