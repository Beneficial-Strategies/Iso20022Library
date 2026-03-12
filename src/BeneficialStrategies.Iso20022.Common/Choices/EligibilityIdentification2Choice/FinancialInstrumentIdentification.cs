// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification2Choice
{
    /// <summary>
    /// ISIN used to identify the security to be defined as eligible.
    /// </summary>
    [IsoId("_oOzV8-LXEeWFtOV72FbX9w")]
    [DisplayName("Financial Instrument Identification")]
    public partial record FinancialInstrumentIdentification : EligibilityIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// The International Securities Identification Number is a code allocated to financial instruments as well as referential instruments, as described in the ISO 6166 standard, associated with the minimum descriptive data.  The ISIN consists of a prefix using the alpha-2 country codes or reserved codes specified in ISO 3166 or other prefixes as may be determined by the Registration Authority for the ISO 6166 standard, a nine characters (alphanumeric) basic code and a check digit.
        /// </summary>
        [IsoXmlTag("FinInstrmId")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public required IsoISINOct2015Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
