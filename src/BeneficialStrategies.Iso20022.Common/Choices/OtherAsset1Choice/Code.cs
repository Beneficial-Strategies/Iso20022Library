// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OtherAsset1Choice
{
    /// <summary>
    /// Other asset type specified as a code.
    /// </summary>
    [IsoId("_L3yDwEyJEeir2sRRVd9XhA")]
    [DisplayName("Code")]
    public record Code : OtherAsset1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of asset
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OtherAsset1Code Value { get; init; }
    }
}
