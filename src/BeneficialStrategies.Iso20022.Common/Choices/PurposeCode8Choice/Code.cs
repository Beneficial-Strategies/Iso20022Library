// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PurposeCode8Choice
{
    /// <summary>
    /// Securities account purpose as an ISO 20022 code.
    /// </summary>
    [IsoId("_5Wx6ZJNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : PurposeCode8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the purpose of the securities account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesAccountPurposeType1Code Value { get; init; }
    }
}
