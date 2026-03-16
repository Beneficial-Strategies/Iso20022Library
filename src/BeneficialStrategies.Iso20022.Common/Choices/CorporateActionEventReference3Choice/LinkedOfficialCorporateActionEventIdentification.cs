// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventReference3Choice
{
    /// <summary>
    /// Official and unique reference assigned by the official central body/ entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_4h3LozncEeWLJsP1cO-amg")]
    [DisplayName("Linked Official Corporate Action Event Identification")]
    public record LinkedOfficialCorporateActionEventIdentification
        : CorporateActionEventReference3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("LkdOffclCorpActnEvtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
