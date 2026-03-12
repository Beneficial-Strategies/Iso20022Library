// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification1Choice
{
    /// <summary>
    /// Missing or incorrect information.
    /// </summary>
    [IsoId("_T-i3Mtp-Ed-ak6NoX_4Aeg_-1346615971")]
    [DisplayName("Missing Or Incorrect Information")]
    public partial record MissingOrIncorrectInformation : UnableToApplyJustification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates the missing information.
        /// </summary>
        [IsoId("_T-ZtS9p-Ed-ak6NoX_4Aeg_-1840697101")]
        [DisplayName("Missing Information")]
        [IsoXmlTag("MssngInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyMissingInfo1Code> MissingInformation { get; init; } = new SimpleValueList<UnableToApplyMissingInfo1Code>(){};
        
        /// <summary>
        /// Indicates the incorrect information.
        /// </summary>
        [IsoId("_T-ZtTNp-Ed-ak6NoX_4Aeg_-1839776740")]
        [DisplayName("Incorrect Information")]
        [IsoXmlTag("IncrrctInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public SimpleValueList<UnableToApplyIncorrectInfo2Code> IncorrectInformation { get; init; } = new SimpleValueList<UnableToApplyIncorrectInfo2Code>(){};
        
        
        #nullable disable
        
    }
}
