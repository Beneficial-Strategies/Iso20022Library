// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PurposeCode2Choice
{
    /// <summary>
    /// Securities account purpose as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qwdxo9p-Ed-ak6NoX_4Aeg_2094982562")]
    [DisplayName("Code")]
    public partial record Code : PurposeCode2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the purpose of the securities account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesAccountPurposeType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
