// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice
{
    /// <summary>
    /// Promise to meet the obligations of a clearing member provided by a third party.
    /// </summary>
    [IsoId("_yMukYK_7EeaE9YROwd69hA")]
    [DisplayName("Guarantee")]
    public record Guarantee : AssetHolding1Choice_
    {
        /// <summary>
        /// Identification of guarantee provider.
        /// </summary>
        [IsoId("_S3vCAK_8EeaE9YROwd69hA")]
        [DisplayName("Provider")]
        [IsoXmlTag("Prvdr")]
        public required PartyIdentification118Choice_ Provider { get; init; }

        /// <summary>
        /// Value of the collateral guarantee.
        /// </summary>
        [IsoId("_WWJpoK_8EeaE9YROwd69hA")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }
    }
}
