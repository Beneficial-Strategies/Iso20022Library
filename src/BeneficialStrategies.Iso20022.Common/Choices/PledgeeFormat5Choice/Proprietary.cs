// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat5Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a proprietary type and narrative description.
    /// </summary>
    [IsoId("_YxN_5dLGEeiN28wlpBQScw")]
    [DisplayName("Proprietary")]
    public record Proprietary : PledgeeFormat5Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_9s3YRTnZEeWV5sr121Fc8A")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required GenericIdentification30 Type { get; init; }

        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity.
        /// </summary>
        [IsoId("_9s3YQznZEeWV5sr121Fc8A")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; }
    }
}
