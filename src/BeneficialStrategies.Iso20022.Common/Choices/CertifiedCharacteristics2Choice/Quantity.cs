// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice
{
    /// <summary>
    /// Quantity of the goods, as proven by the certificate.
    /// </summary>
    [IsoId("_3DBVOTANEeOKib24wnHaFg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public record Quantity : CertifiedCharacteristics2Choice_
    {
        /// <summary>
        /// Specifies a unit of measure with a code or free text.
        /// </summary>
        [IsoId("_nbGTIBraEeOVR9VN6fAMUg")]
        [DisplayName("Unit Of Measure")]
        [IsoXmlTag("UnitOfMeasr")]
        public required UnitOfMeasure3Choice_ UnitOfMeasure { get; init; }

        /// <summary>
        /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
        /// </summary>
        [IsoId("_6QbP1xrZEeOVR9VN6fAMUg")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; }

        /// <summary>
        /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
        /// </summary>
        [IsoId("_6QbP2RrZEeOVR9VN6fAMUg")]
        [DisplayName("Factor")]
        [IsoXmlTag("Fctr")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public IsoMax15NumericText? Factor { get; init; }
    }
}
