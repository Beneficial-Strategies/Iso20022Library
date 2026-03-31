// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateTimeOrBlankQuery1Choice
{
    /// <summary>
    /// Field may be queried for not reported value.
    /// </summary>
    [IsoId("_HaZjo2E4Ee2S65ml6YCOtA")]
    [DisplayName("Not Reported")]
    public record NotReported : DateTimeOrBlankQuery1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a not reported value code.
        /// </summary>
        [IsoXmlTag("NotRptd")]
        public required NotReported1Code Value { get; init; }
    }
}
