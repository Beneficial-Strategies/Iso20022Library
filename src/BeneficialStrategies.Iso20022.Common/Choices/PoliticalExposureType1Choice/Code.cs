// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PoliticalExposureType1Choice
{
    /// <summary>
    /// Type of political exposure expressed as a code.
    /// </summary>
    [IsoId("_rL9LMBRvEeOKWo1NF21OVw")]
    [DisplayName("Code")]
    public record Code : PoliticalExposureType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the political exposure type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PoliticalExposureType1Code Value { get; init; }
    }
}
