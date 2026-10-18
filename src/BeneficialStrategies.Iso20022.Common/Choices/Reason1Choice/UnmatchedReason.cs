// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_UXuzQNp-Ed-ak6NoX_4Aeg_-1432609898")]
    [DisplayName("Unmatched Reason")]
    public partial record UnmatchedReason : Reason1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UmtchdRsn")]
        public required UnmatchedReason2Choice_ Value { get; init; }
    }
}
