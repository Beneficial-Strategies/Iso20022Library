// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// United Kingdom (UK) Sort Code - identifies British financial institutions on the British national clearing systems. The sort code is assigned by the Association for Payments and Clearing Services (APACS).
    /// </summary>
    [IsoId("_TC8Kktp-Ed-ak6NoX_4Aeg_1989939782")]
    [DisplayName("UK Domestic Sort Code")]
    public record UKDomesticSortCode : ClearingSystemMemberIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// United Kingdom (UK) Sort Code. Identifies British financial institutions on the British national clearing systems. The sort code is assigned by the Association for Payments and Clearing Services (APACS).
        /// </summary>
        [IsoXmlTag("GBSC")]
        [IsoSimpleType(IsoSimpleType.UKDomesticSortCodeIdentifier)]
        public required IsoUKDomesticSortCodeIdentifier Value { get; init; }
    }
}
