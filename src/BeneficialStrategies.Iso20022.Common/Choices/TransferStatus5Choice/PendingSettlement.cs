// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus5Choice
{
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_WY1VQ-ijEeuLe8v4JEtDDg")]
    [DisplayName("Pending Settlement")]
    public partial record PendingSettlement : TransferStatus5Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgSttlm")]
        public required PendingSettlementStatus3Choice_ Value { get; init; }
    }
}
