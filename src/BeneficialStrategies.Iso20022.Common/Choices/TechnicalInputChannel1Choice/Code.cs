// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TechnicalInputChannel1Choice
{
    /// <summary>
    /// Technical input channel, as published in an external technical input channel code list.
    /// </summary>
    [IsoId("_Rpr4otp-Ed-ak6NoX_4Aeg_-968156368")]
    [DisplayName("Code")]
    public record Code : TechnicalInputChannel1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the technical input channel, as published in an external technical input channel code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTechnicalInputChannel1Code Value { get; init; }
    }
}
