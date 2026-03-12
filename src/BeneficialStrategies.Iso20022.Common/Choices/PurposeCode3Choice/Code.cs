// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PurposeCode3Choice
{
    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_XN-Aktp-Ed-ak6NoX_4Aeg_994414522")]
    [DisplayName("Code")]
    public partial record Code : PurposeCode3Choice_
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
