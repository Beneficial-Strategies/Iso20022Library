// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ActivityIndicator1Choice
{
    /// <summary>
    /// ISIC Identifier.
    /// </summary>
    [DisplayName("ISIC Identifier")]
    public record ISICIdentifier : ActivityIndicator1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ISICIdr")]
        // The variant is named like its type, so the type is written in full.
        public required BeneficialStrategies.Iso20022.SimpleTypes.ISICIdentifier Value { get; init; }
    }
}
