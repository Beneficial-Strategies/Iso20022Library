// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification30Choice
{
    /// <summary>
    /// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, that is, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.
    /// </summary>
    [IsoId("_cZCyg3s8EeSTS7uHCe8FPQ")]
    [DisplayName("BBAN")]
    public partial record BBAN : AccountIdentification30Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Basic Bank Account Number (BBAN). Identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), which uniquely identifies the account of a customer.
        /// </summary>
        [IsoXmlTag("BBAN")]
        [IsoSimpleType(IsoSimpleType.BBANIdentifier)]
        public required IsoBBANIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
