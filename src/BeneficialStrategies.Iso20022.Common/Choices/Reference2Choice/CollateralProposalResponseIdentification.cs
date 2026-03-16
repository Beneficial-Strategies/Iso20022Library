// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference2Choice
{
    /// <summary>
    /// Unique identifier of the collateral proposal response.
    /// </summary>
    [IsoId("_TYW3kqerEeCq2KR6DaC1kQ_-2112953758")]
    [DisplayName("Collateral Proposal Response Identification")]
    public record CollateralProposalResponseIdentification : Reference2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("CollPrpslRspnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
