// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData3Choice
{
    /// <inheritdoc cref="IDirectDebitMandate"/>
    [DisplayName("Direct Debit Mandate")]
    public partial record DirectDebitMandate : MandateRelatedData3Choice_
    {
        /// <inheritdoc cref="IDirectDebitMandate.Value"/>
        [IsoXmlTag("DrctDbtMndt")]
        public required MandateRelatedInformation16 Value { get; init; }
    }
}
