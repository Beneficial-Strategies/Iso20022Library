// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice
{
    /// <inheritdoc cref="IUPIC"/>
    [IsoId("_PdnCqNp-Ed-ak6NoX_4Aeg_639959793")]
    [DisplayName("UPIC")]
    public partial record UPIC : AccountIdentification3Choice_
    {
        /// <inheritdoc cref="IUPIC.Value"/>
        [IsoXmlTag("UPIC")]
        [IsoSimpleType(IsoSimpleType.UPICIdentifier)]
        public required IsoUPICIdentifier Value { get; init; }
    }
}
