// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification2Choice
{
    /// <summary>
    /// Set of elements used to indicate which information is missing or incorrect.
    /// </summary>
    [IsoId("_T-i3Ndp-Ed-ak6NoX_4Aeg_-1089125167")]
    [DisplayName("Missing Or Incorrect Information")]
    public record MissingOrIncorrectInformation : UnableToApplyJustification2Choice_
    {
        /// <summary>
        /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
        /// </summary>
        [IsoId("_T-soMNp-Ed-ak6NoX_4Aeg_257368960")]
        [DisplayName("Anti Money Laundering Request")]
        [IsoXmlTag("AMLReq")]
        [IsoSimpleType(IsoSimpleType.AMLIndicator)]
        public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; }

        /// <summary>
        /// Indicates the missing information.
        /// </summary>
        [IsoId("_T-soMdp-Ed-ak6NoX_4Aeg_-689240580")]
        [DisplayName("Missing Information")]
        [IsoXmlTag("MssngInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyMissingInformation2Code> MissingInformation { get; init; } =
            [];

        /// <summary>
        /// Indicates, in a coded form, the incorrect information.
        /// </summary>
        [IsoId("_T-soMtp-Ed-ak6NoX_4Aeg_-689240558")]
        [DisplayName("Incorrect Information")]
        [IsoXmlTag("IncrrctInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyIncorrectInformation3Code> IncorrectInformation { get; init; } =
            [];
    }
}
