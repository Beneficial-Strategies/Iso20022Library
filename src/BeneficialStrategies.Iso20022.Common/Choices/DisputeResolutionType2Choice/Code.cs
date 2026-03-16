// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DisputeResolutionType2Choice
{
    /// <summary>
    /// Code to specify the type of dispute that is to be resolved regarding the disputed collateral amount.
    /// </summary>
    [IsoId("_UnrTytp-Ed-ak6NoX_4Aeg_61652399")]
    [DisplayName("Code")]
    public record Code : DisputeResolutionType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the disputed collateral amount.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DisputeResolutionType2Code Value { get; init; }
    }
}
