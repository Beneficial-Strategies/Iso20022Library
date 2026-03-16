// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification4Choice
{
    /// <summary>
    /// Set of elements used to indicate which information is missing or incorrect.
    /// </summary>
    [IsoId("_7MMKY9jKEeq5MfBBxQig1Q")]
    [DisplayName("Missing Or Incorrect Information")]
    public record MissingOrIncorrectInformation : UnableToApplyJustification4Choice_
    {
        /// <summary>
        /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
        /// </summary>
        [IsoId("_7O3D4djKEeq5MfBBxQig1Q")]
        [DisplayName("Anti Money Laundering Request")]
        [IsoXmlTag("AMLReq")]
        [IsoSimpleType(IsoSimpleType.AMLIndicator)]
        public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; }

        /// <summary>
        /// Indicates the missing information.
        /// </summary>
        [IsoId("_7O3D49jKEeq5MfBBxQig1Q")]
        [DisplayName("Missing Information")]
        [IsoXmlTag("MssngInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<UnableToApplyMissing2> MissingInformation { get; init; } = [];

        /// <summary>
        /// Indicates, in a coded form, the incorrect information.
        /// </summary>
        [IsoId("_7O3D5djKEeq5MfBBxQig1Q")]
        [DisplayName("Incorrect Information")]
        [IsoXmlTag("IncrrctInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<UnableToApplyIncorrect2> IncorrectInformation { get; init; } = [];
    }
}
