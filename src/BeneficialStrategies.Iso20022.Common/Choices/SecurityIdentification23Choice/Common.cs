// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
    /// </summary>
    [IsoId("_CSq4TSGQEeW7gKYhAMEFCw")]
    [DisplayName("Common")]
    public partial record Common : SecurityIdentification23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
        /// </summary>
        [IsoXmlTag("Cmon")]
        [IsoSimpleType(IsoSimpleType.EuroclearClearstreamIdentifier)]
        public required IsoEuroclearClearstreamIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
