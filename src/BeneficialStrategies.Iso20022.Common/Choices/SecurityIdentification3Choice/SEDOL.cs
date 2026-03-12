// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
    /// </summary>
    [IsoId("_Qdr_kdp-Ed-ak6NoX_4Aeg_1796754500")]
    [DisplayName("SEDOL")]
    public partial record SEDOL : SecurityIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
        /// </summary>
        [IsoXmlTag("SEDOL")]
        [IsoSimpleType(IsoSimpleType.SEDOLIdentifier)]
        public required IsoSEDOLIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
