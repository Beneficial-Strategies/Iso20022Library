// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References18Choice
{
    /// <summary>
    /// Unambiguous identification of the report to be cancelled.
    /// </summary>
    [IsoId("_9Eijcz9mEeCuVfEpWlZb5g")]
    [DisplayName("Securities Settlement Transaction Allegement Report Identification")]
    public record SecuritiesSettlementTransactionAllegementReportIdentification
        : References18Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("SctiesSttlmTxAllgmtRptId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
