// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient12Choice
{
    /// <summary>
    /// Certificate issuer name and serial number (see ITU X.509).
    /// </summary>
    [IsoId("_TNT_oVFKEeyApZmLzm74zA")]
    [DisplayName("Issuer And Serial Number")]
    public partial record IssuerAndSerialNumber : Recipient12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Certificate issuer name (see X.509).
        /// </summary>
        [IsoId("_-8B2IS8iEeu125Ip9zFcsQ")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        public required CertificateIssuer1 Issuer { get; init; } 
        
        /// <summary>
        /// Certificate serial number (see X.509).
        /// </summary>
        [IsoId("_-8B2Iy8iEeu125Ip9zFcsQ")]
        [DisplayName("Serial Number")]
        [IsoXmlTag("SrlNb")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        public required IsoMax500Binary SerialNumber { get; init; } 
        
        
        #nullable disable
        
    }
}
