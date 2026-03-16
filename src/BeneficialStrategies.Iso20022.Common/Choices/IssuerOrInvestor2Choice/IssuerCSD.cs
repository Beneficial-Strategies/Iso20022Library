// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IssuerOrInvestor2Choice
{
    /// <summary>
    /// Issuer CSD.
    /// </summary>
    [DisplayName("Issuer CSD")]
    public partial record IssuerCSD : IssuerOrInvestor2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IssrCSD")]
        public required SystemPartyIdentification2Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
