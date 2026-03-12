// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccount2Choice
{
    /// <summary>
    /// Unique identification of the securities account.
    /// </summary>
    [IsoId("_4H1_o-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Account")]
    public partial record Account : SecuritiesAccount2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_T_JUK9p-Ed-ak6NoX_4Aeg_1862799235")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        /// <summary>
        /// Specifies the type of securities account.
        /// </summary>
        [IsoId("_T_JULNp-Ed-ak6NoX_4Aeg_865726882")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public GenericIdentification30? Type { get; init; } 
        
        /// <summary>
        /// Description of the account.
        /// </summary>
        [IsoId("_T_JULdp-Ed-ak6NoX_4Aeg_-54306770")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? Name { get; init; } 
        
        
        #nullable disable
        
    }
}
