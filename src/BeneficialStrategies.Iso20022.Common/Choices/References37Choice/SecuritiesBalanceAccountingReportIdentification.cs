// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References37Choice
{
    /// <summary>
    /// Unambiguous identification of the report message to be cancelled.
    /// </summary>
    [IsoId("_ts-sKQ34EeKN_Y-2Awiamw")]
    [DisplayName("Securities Balance Accounting Report Identification")]
    public record SecuritiesBalanceAccountingReportIdentification : References37Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("SctiesBalAcctgRptId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
