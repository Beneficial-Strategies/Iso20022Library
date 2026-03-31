// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery4Choice
{
    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_PJPwq5NeEeytjZlcgApf6A")]
    [DisplayName("Not Reported")]
    public record NotReported : SecurityIdentificationQuery4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a not reported value code.
        /// </summary>
        [IsoXmlTag("NotRptd")]
        public required NotReported1Code Value { get; init; }
    }
}
