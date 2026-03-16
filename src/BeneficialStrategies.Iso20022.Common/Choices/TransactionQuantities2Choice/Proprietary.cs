// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionQuantities2Choice
{
    /// <summary>
    /// Proprietary quantities specification defined in the underlying transaction.
    /// </summary>
    [IsoId("_tqS1MVkyEeGeoaLUQk__nA_2026377494")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : TransactionQuantities2Choice_
    {
        /// <summary>
        /// Identifies the type of proprietary quantity reported.
        /// </summary>
        [IsoId("_RUhg99p-Ed-ak6NoX_4Aeg_-1425714266")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Type { get; init; }

        /// <summary>
        /// Provides the proprietary quantity in free format.
        /// </summary>
        [IsoId("_RUrR8Np-Ed-ak6NoX_4Aeg_1280200217")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Quantity { get; init; }
    }
}
