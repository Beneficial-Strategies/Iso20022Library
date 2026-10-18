// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData3Choice
{
    /// <inheritdoc cref="ICreditTransferMandate"/>
    [DisplayName("Credit Transfer Mandate")]
    public partial record CreditTransferMandate : MandateRelatedData3Choice_
    {
        /// <inheritdoc cref="ICreditTransferMandate.Value"/>
        [IsoXmlTag("CdtTrfMndt")]
        public required CreditTransferMandateData1 Value { get; init; }
    }
}
