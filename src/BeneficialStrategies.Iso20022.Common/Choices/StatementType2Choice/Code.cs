// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementType2Choice
{
    /// <summary>
    /// Statement type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QrZrfNp-Ed-ak6NoX_4Aeg_1743322244")]
    [DisplayName("Code")]
    public record Code : StatementType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the statement is an accounting or a custody statement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesStatementType1Code Value { get; init; }
    }
}
