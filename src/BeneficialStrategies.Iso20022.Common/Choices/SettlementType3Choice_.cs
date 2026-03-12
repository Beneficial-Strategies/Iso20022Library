// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for settlement type.
    /// </summary>
    [KnownType(typeof(SettlementType3Choice.Code))]
    [KnownType(typeof(SettlementType3Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementType3Choice.Code),nameof(SettlementType3Choice.Code))]
    [JsonDerivedType(typeof(SettlementType3Choice.Proprietary),nameof(SettlementType3Choice.Proprietary))]
    [IsoId("_2VKQNeLbEeWFtOV72FbX9w")]
    [DisplayName("Settlement Type 3 Choice")]
    public abstract partial record SettlementType3Choice_
    {
    }
}
