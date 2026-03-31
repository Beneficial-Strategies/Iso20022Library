// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// Canadian Payments Association Routing Number - identifies Canadian financial institutions on the Canadian national clearing system.
    /// </summary>
    [IsoId("_TDY2idp-Ed-ak6NoX_4Aeg_-896562587")]
    [DisplayName("Canadian Payments Association Routing Number Identification")]
    public record CanadianPaymentsAssociationRoutingNumberIdentification
        : ClearingSystemMemberIdentificationChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Canadian Payments Association Routing Number. Identifies Canadian financial institutions on the Canadian national clearing system.
        /// </summary>
        [IsoXmlTag("CACPA")]
        [IsoSimpleType(IsoSimpleType.CanadianPaymentsARNIdentifier)]
        public required IsoCanadianPaymentsARNIdentifier Value { get; init; }
    }
}
