// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat67Choice
{
    /// <summary>
    /// Date Code.
    /// </summary>
    [DisplayName("Date Code")]
    public record DateCode : DateFormat67Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DtCd")]
        public required DateCode35Choice_ Value { get; init; }
    }
}
