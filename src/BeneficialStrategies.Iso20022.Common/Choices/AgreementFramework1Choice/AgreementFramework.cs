// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AgreementFramework1Choice
{
    /// <summary>
    /// Code to specify the type of collateral agreement.
    /// </summary>
    [IsoId("_UkjHQNp-Ed-ak6NoX_4Aeg_-1888228410")]
    [DisplayName("Agreement Framework")]
    public record AgreementFramework : AgreementFramework1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the agreement type details for the margin call.
        /// </summary>
        [IsoXmlTag("AgrmtFrmwk")]
        public required AgreementFramework1Code Value { get; init; }
    }
}
