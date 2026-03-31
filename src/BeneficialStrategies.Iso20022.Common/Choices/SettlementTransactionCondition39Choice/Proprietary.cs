// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition39Choice
{
    /// <summary>
    /// Settlement conditions expressed as a proprietary code.
    /// </summary>
    [IsoId("_NIiaPSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : SettlementTransactionCondition39Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_ux_-tSb3EeK33eWt3gq4Fg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText Identification { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_ux_-uSb3EeK33eWt3gq4Fg")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Issuer { get; init; }

        /// <summary>
        /// Short textual description of the scheme.
        /// </summary>
        [IsoId("_ux_-vSb3EeK33eWt3gq4Fg")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public IsoMax4AlphaNumericText? SchemeName { get; init; }
    }
}
