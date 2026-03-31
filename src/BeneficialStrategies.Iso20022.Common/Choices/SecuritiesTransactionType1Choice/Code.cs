// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType1Choice
{
    /// <summary>
    /// Securities transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QuOV99p-Ed-ak6NoX_4Aeg_-1588234947")]
    [DisplayName("Code")]
    public record Code : SecuritiesTransactionType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of settlement transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesTransactionType1Code Value { get; init; }
    }
}
