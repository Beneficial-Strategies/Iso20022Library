// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustificationChoice
{
    /// <summary>
    /// Missing or incorrect information.
    /// </summary>
    [IsoId("_VFn0ENp-Ed-ak6NoX_4Aeg_478745608")]
    [DisplayName("Missing Or Incorrect Information")]
    public partial record MissingOrIncorrectInformation : UnableToApplyJustificationChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates the missing information.
        /// </summary>
        [IsoId("_VFn0DNp-Ed-ak6NoX_4Aeg_-2094358719")]
        [DisplayName("Missing Information")]
        [IsoXmlTag("MssngInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyMissingInfo1Code> MissingInformation { get; init; } = new SimpleValueList<UnableToApplyMissingInfo1Code>(){};
        
        /// <summary>
        /// Indicates the incorrect information.
        /// </summary>
        [IsoId("_VFn0Ddp-Ed-ak6NoX_4Aeg_1320808370")]
        [DisplayName("Incorrect Information")]
        [IsoXmlTag("IncrrctInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyIncorrectInfo1Code> IncorrectInformation { get; init; } = new SimpleValueList<UnableToApplyIncorrectInfo1Code>(){};
        
        
        #nullable disable
        
    }
}
