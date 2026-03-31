// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosingBalance3Choice
{
    /// <summary>
    /// Closing balance of the financial instrument in the statement.
    /// </summary>
    [IsoId("_96S_QQgHEeSxsfb1OEDVsw")]
    [DisplayName("Final Closing Balance")]
    public record FinalClosingBalance : ClosingBalance3Choice_
    {
        /// <summary>
        /// Quantity expressed as a number, eg, a number of shares.
        /// </summary>
        [IsoId("_SoH21dp-Ed-ak6NoX_4Aeg_-1748202212")]
        [DisplayName("Unit")]
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Unit { get; init; }
    }
}
