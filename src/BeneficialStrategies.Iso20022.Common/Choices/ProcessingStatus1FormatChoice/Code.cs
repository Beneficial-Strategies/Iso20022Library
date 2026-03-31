// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus1FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing status.
    /// </summary>
    [IsoId("_Rnv-9Np-Ed-ak6NoX_4Aeg_-1777014631")]
    [DisplayName("Code")]
    public record Code : ProcessingStatus1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingStatus1Code Value { get; init; }
    }
}
