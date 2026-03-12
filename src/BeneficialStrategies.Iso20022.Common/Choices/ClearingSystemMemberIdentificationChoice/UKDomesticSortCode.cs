// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// United Kingdom (UK) Sort Code - identifies British financial institutions on the British national clearing systems. The sort code is assigned by the Association for Payments and Clearing Services (APACS).
    /// </summary>
    [IsoId("_TDY2gdp-Ed-ak6NoX_4Aeg_-896562603")]
    [DisplayName("UK Domestic Sort Code")]
    public partial record UKDomesticSortCode : ClearingSystemMemberIdentificationChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// United Kingdom (UK) Sort Code. Identifies British financial institutions on the British national clearing systems. The sort code is assigned by the Association for Payments and Clearing Services (APACS).
        /// </summary>
        [IsoXmlTag("GBSC")]
        [IsoSimpleType(IsoSimpleType.UKDomesticSortCodeIdentifier)]
        public required IsoUKDomesticSortCodeIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
