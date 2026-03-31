// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// Fedwire Routing Number - identifies financial institutions, in the US, on the FedWire system. The routing number is assigned by the American Bankers Association (ABA).
    /// </summary>
    [IsoId("_TDY2hNp-Ed-ak6NoX_4Aeg_-896562600")]
    [DisplayName("Fedwire Routing Number Identification")]
    public record FedwireRoutingNumberIdentification : ClearingSystemMemberIdentificationChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Fedwire Routing Number. Identifies financial institutions, in the US, on the FedWire system. The routing number is assigned by the American Bankers Association (ABA).
        /// </summary>
        [IsoXmlTag("USFW")]
        [IsoSimpleType(IsoSimpleType.FedwireRoutingNumberIdentifier)]
        public required IsoFedwireRoutingNumberIdentifier Value { get; init; }
    }
}
