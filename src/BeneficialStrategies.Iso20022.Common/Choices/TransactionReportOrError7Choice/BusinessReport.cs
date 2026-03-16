// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionReportOrError7Choice
{
    /// <summary>
    /// Business Report.
    /// </summary>
    [DisplayName("Business Report")]
    public record BusinessReport : TransactionReportOrError7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BizRpt")]
        public required Transactions11 Value { get; init; }
    }
}
