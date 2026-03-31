// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference3Choice
{
    /// <summary>
    /// Reference assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("_sW8TgQLyEeutW5-TpeYJhA")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    public record TripartyAgentServiceProviderCollateralInstructionIdentification
        : Reference3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
