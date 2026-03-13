// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification3Choice
{
    /// <summary>
    /// Set of elements used to indicate which information is missing or incorrect.
    /// </summary>
    [IsoId("_S_E3FUgoEeaGKYpLDboHPQ")]
    [DisplayName("Missing Or Incorrect Information")]
    public partial record MissingOrIncorrectInformation : UnableToApplyJustification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
        /// </summary>
        [IsoId("_eA4sw0gqEeaGKYpLDboHPQ")]
        [DisplayName("Anti Money Laundering Request")]
        [IsoXmlTag("AMLReq")]
        [IsoSimpleType(IsoSimpleType.AMLIndicator)]
        public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; } 
        
        /// <summary>
        /// Indicates the missing information.
        /// </summary>
        [IsoId("_eA4sxUgqEeaGKYpLDboHPQ")]
        [DisplayName("Missing Information")]
        [IsoXmlTag("MssngInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<UnableToApplyMissing1> MissingInformation { get; init; } = [];
        
        /// <summary>
        /// Indicates, in a coded form, the incorrect information.
        /// </summary>
        [IsoId("_eA4sx0gqEeaGKYpLDboHPQ")]
        [DisplayName("Incorrect Information")]
        [IsoXmlTag("IncrrctInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<UnableToApplyIncorrect1> IncorrectInformation { get; init; } = [];
        
        
        #nullable disable
        
    }
}
