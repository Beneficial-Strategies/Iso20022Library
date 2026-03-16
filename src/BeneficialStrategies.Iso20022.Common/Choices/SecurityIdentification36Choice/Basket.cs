// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification36Choice
{
    /// <summary>
    /// Identification of constituents for a basket of indexes.
    /// </summary>
    [IsoId("_POTEp4rpEeq91phomTRDDA")]
    [DisplayName("Basket")]
    [IsoXmlTag("Bskt")]
    public record Basket : SecurityIdentification36Choice_
    {
        /// <summary>
        /// Identification of the structurer of the customer basket.
        /// </summary>
        [IsoId("_lQQRIP5yEeqiEZtcZLwc3Q")]
        [DisplayName("Structurer")]
        [IsoXmlTag("Strr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Structurer { get; init; }

        /// <summary>
        /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
        /// </summary>
        [IsoId("_EfWm0QFOEeqUa4noT3P56A")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text Identification { get; init; }

        /// <summary>
        /// Identifier of the underliers that represent the constituents of a custom basket.
        /// </summary>
        [IsoId("_HI1KgQFOEeqUa4noT3P56A")]
        [DisplayName("Constituents")]
        [IsoXmlTag("Cnsttnts")]
        public ValueList<BasketConstituents1> Constituents { get; init; } = [];
        // ID for the above is _HI1KgQFOEeqUa4noT3P56A
    }
}
