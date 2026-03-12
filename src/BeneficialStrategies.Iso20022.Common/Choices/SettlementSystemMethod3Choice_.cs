// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement system/method.
    /// </summary>
    [KnownType(typeof(SettlementSystemMethod3Choice.Code))]
    [KnownType(typeof(SettlementSystemMethod3Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementSystemMethod3Choice.Code),nameof(SettlementSystemMethod3Choice.Code))]
    [JsonDerivedType(typeof(SettlementSystemMethod3Choice.Proprietary),nameof(SettlementSystemMethod3Choice.Proprietary))]
    [IsoId("_AZQqAdokEeC60axPepSq7g_1949401070")]
    [DisplayName("Settlement System Method 3 Choice")]
    public abstract partial record SettlementSystemMethod3Choice_
    {
    }
}
