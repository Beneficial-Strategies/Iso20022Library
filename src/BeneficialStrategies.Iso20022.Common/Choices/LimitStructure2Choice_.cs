// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit details of one or more limits set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(LimitStructure2Choice.CurrentLimitIdentification))]
    [KnownType(typeof(LimitStructure2Choice.AllCurrentLimits))]
    [JsonDerivedType(typeof(LimitStructure2Choice.CurrentLimitIdentification),nameof(LimitStructure2Choice.CurrentLimitIdentification))]
    [JsonDerivedType(typeof(LimitStructure2Choice.AllCurrentLimits),nameof(LimitStructure2Choice.AllCurrentLimits))]
    [IsoId("__lXa7249EeiU9cctagi5ow")]
    [DisplayName("Limit Structure 2 Choice")]
    public abstract partial record LimitStructure2Choice_
    {
    }
}
