// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Recipient9Choice
{
    /// <summary>
    /// Certificate issuer name and serial number (see ITU X.509).
    /// </summary>
    [IsoId("_M0YGAS8jEeu125Ip9zFcsQ")]
    [DisplayName("Issuer And Serial Number")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IssuerAndSerialNumber : Recipient9Choice_
    #else
    public partial class IssuerAndSerialNumber : Recipient9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IssuerAndSerialNumber instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IssuerAndSerialNumber( CertificateIssuer1 reqIssuer,System.Byte[] reqSerialNumber )
        {
            Issuer = reqIssuer;
            SerialNumber = reqSerialNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Certificate issuer name (see X.509).
        /// </summary>
        [IsoId("_-8B2IS8iEeu125Ip9zFcsQ")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CertificateIssuer1 Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CertificateIssuer1 Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CertificateIssuer1 Issuer { get; init; } 
        #else
        public CertificateIssuer1 Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Certificate serial number (see X.509).
        /// </summary>
        [IsoId("_-8B2Iy8iEeu125Ip9zFcsQ")]
        [DisplayName("Serial Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SrlNb")]
        #endif
        [IsoXmlTag("SrlNb")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax500Binary SerialNumber { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Byte[] SerialNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[] SerialNumber { get; init; } 
        #else
        public System.Byte[] SerialNumber { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
