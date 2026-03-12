// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement system/method.
    /// </summary>
    [KnownType(typeof(SettlementSystemMethod5Choice.Code))]
    [KnownType(typeof(SettlementSystemMethod5Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementSystemMethod5Choice.Code),nameof(SettlementSystemMethod5Choice.Code))]
    [JsonDerivedType(typeof(SettlementSystemMethod5Choice.Proprietary),nameof(SettlementSystemMethod5Choice.Proprietary))]
    [IsoId("_5TKlQ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement System Method 5 Choice")]
    public abstract partial record SettlementSystemMethod5Choice_
    {
    }
}
