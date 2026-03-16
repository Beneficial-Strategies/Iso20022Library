// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate3Choice
{
    /// <summary>
    /// Date expressed as a code.
    /// </summary>
    [IsoId("_-a7YkaMOEeCojJW5vEuTEQ_233612286")]
    [DisplayName("Date Code")]
    public record DateCode : TradeDate3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is unknown.
        /// </summary>
        [IsoXmlTag("DtCd")]
        public required DateType1Code Value { get; init; }
    }
}
