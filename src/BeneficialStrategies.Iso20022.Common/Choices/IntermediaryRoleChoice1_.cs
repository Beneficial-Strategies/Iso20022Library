// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of intermediary role.
    /// </summary>
    [KnownType(typeof(IntermediaryRoleChoice1.Role))]
    [KnownType(typeof(IntermediaryRoleChoice1.Proprietary))]
    [JsonDerivedType(typeof(IntermediaryRoleChoice1.Role),nameof(IntermediaryRoleChoice1.Role))]
    [JsonDerivedType(typeof(IntermediaryRoleChoice1.Proprietary),nameof(IntermediaryRoleChoice1.Proprietary))]
    [IsoId("_RhC6Btp-Ed-ak6NoX_4Aeg_991190006")]
    [DisplayName("Intermediary Role Choice")]
    public abstract partial record IntermediaryRoleChoice1_
    {
    }
}
