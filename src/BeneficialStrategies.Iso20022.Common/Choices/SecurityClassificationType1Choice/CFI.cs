// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityClassificationType1Choice
{
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification.
    /// </summary>
    [IsoId("_Q7pG4tp-Ed-ak6NoX_4Aeg_-1460086177")]
    [DisplayName("CFI")]
    public partial record CFI : SecurityClassificationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification, eg, common share with voting rights, fully paid, or registered.
        /// </summary>
        [IsoXmlTag("CFI")]
        [IsoSimpleType(IsoSimpleType.CFIIdentifier)]
        public required IsoCFIIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
