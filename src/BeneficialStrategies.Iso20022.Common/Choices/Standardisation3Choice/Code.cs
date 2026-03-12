// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Standardisation3Choice
{
    /// <summary>
    /// Standardisation expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_PnpgwWp7EemmaZLSPtWX5A")]
    [DisplayName("Code")]
    public partial record Code : Standardisation3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the terms of the security (underlying instruments, expiration date, contract size) are defined according to the exchange specifications or whether they can be user defined.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Standardisation1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
