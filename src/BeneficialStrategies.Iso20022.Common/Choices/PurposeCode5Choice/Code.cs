// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PurposeCode5Choice
{
    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_AeoSMNokEeC60axPepSq7g_1620251894")]
    [DisplayName("Code")]
    public record Code : PurposeCode5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the purpose of the securities account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesAccountPurposeType1Code Value { get; init; }
    }
}
