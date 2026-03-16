// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [KnownType(typeof(References70Choice.ClientCollateralInstructionIdentification))]
    [KnownType(
        typeof(References70Choice.TripartyAgentServiceProviderCollateralInstructionIdentification)
    )]
    [JsonDerivedType(
        typeof(References70Choice.ClientCollateralInstructionIdentification),
        nameof(References70Choice.ClientCollateralInstructionIdentification)
    )]
    [JsonDerivedType(
        typeof(References70Choice.TripartyAgentServiceProviderCollateralInstructionIdentification),
        nameof(References70Choice.TripartyAgentServiceProviderCollateralInstructionIdentification)
    )]
    [IsoId("_21pbMFSLEemTt7251YwCKw")]
    [DisplayName("References 70 Choice")]
    public abstract record References70Choice_ { }
}
