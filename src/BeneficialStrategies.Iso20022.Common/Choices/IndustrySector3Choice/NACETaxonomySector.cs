// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndustrySector3Choice
{
    /// <summary>
    /// NACE Taxonomy Sector.
    /// </summary>
    [DisplayName("NACE Taxonomy Sector")]
    public record NACETaxonomySector : IndustrySector3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NACETxnmySctr")]
        public required IsoNACEDomain2025Identifier Value { get; init; }
    }
}
