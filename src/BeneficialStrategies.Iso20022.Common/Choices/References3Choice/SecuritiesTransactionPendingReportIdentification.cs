// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References3Choice
{
    /// <summary>
    /// Unambiguous identification of the report message to be cancelled.
    /// </summary>
    [IsoId("_USz3A9p-Ed-ak6NoX_4Aeg_-1351459157")]
    [DisplayName("Securities Transaction Pending Report Identification")]
    public record SecuritiesTransactionPendingReportIdentification : References3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("SctiesTxPdgRptId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
