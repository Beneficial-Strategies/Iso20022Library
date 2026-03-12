// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosingBalance3Choice
{
    /// <summary>
    /// Closing Balance of this page only. Must be the intermediary opening balance of the next page (part of the same statement).
    /// </summary>
    [IsoId("__BaYUQgHEeSxsfb1OEDVsw")]
    [DisplayName("Intermediary Closing Balance")]
    public partial record IntermediaryClosingBalance : ClosingBalance3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Quantity expressed as a number, eg, a number of shares.
        /// </summary>
        [IsoId("_SoH21dp-Ed-ak6NoX_4Aeg_-1748202212")]
        [DisplayName("Unit")]
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Unit { get; init; } 
        
        
        #nullable disable
        
    }
}
