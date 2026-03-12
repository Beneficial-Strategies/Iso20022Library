// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountOrOperationalError3Choice
{
    /// <summary>
    /// Reports either on the account information or on a business error.
    /// </summary>
    [IsoId("_fSjb8Z-WEee28J7y9KlTWg")]
    [DisplayName("Account Report")]
    public partial record AccountReport : AccountOrOperationalError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_fd0Qw5-WEee28J7y9KlTWg")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public required AccountIdentification4Choice_ AccountIdentification { get; init; } 
        
        /// <summary>
        /// Requested information on the account or business error when information has not been found.
        /// </summary>
        [IsoId("_fd0QxZ-WEee28J7y9KlTWg")]
        [DisplayName("Account Or Error")]
        [IsoXmlTag("AcctOrErr")]
        public required AccountOrBusinessError3Choice_ AccountOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
