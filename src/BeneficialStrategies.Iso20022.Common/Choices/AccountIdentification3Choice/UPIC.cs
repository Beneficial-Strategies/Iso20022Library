// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice
{
    /// <summary>
    /// Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
    /// </summary>
    [IsoId("_PdnCqNp-Ed-ak6NoX_4Aeg_639959793")]
    [DisplayName("UPIC")]
    public partial record UPIC : AccountIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Universal Payment Identification Code (UPIC). Identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
        /// </summary>
        [IsoXmlTag("UPIC")]
        [IsoSimpleType(IsoSimpleType.UPICIdentifier)]
        public required IsoUPICIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
