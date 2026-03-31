// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Reuters Identification Code (RIC). A numbering system used within the Reuters system to identify instruments worldwide. The RIC contains an X-character market specific code (can be the CUSIP or EPIC codes) followed by a full stop, then the two-digit ISO country code, eg, IBM in UK is IBM.UK.
    /// </summary>
    [IsoId("_Qdr_k9p-Ed-ak6NoX_4Aeg_1064399328")]
    [DisplayName("RIC")]
    public record RIC : SecurityIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Reuters Identification Code (RIC). A numbering system used within the Reuters system to identify instruments worldwide. The RIC contains an X-character market specific code (can be the CUSIP or EPIC codes) followed by a full stop, then the two-digit ISO country code, for example, IBM in UK is IBM.UK.
        /// </summary>
        [IsoXmlTag("RIC")]
        [IsoSimpleType(IsoSimpleType.RICIdentifier)]
        public required IsoRICIdentifier Value { get; init; }
    }
}
