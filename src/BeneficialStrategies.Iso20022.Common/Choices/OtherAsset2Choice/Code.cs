// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OtherAsset2Choice
{
    /// <summary>
    /// Other asset type specified as a code.
    /// </summary>
    [IsoId("__RowIZNBEemQB_8XA98K0Q")]
    [DisplayName("Code")]
    public record Code : OtherAsset2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of asset.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OtherAsset2Code Value { get; init; }
    }
}
