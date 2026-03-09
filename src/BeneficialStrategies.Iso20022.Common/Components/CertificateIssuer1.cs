// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate issuer name (see X.509).
/// </summary>
[IsoId("_Sw--vQEcEeCQm6a_G2yO_w_152932975")]
[DisplayName("Certificate Issuer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificateIssuer1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Relative distinguished name inside a X.509 certificate.
    /// </summary>
    [IsoId("_SxIvsAEcEeCQm6a_G2yO_w_1329577257")]
    [DisplayName("Relative Distinguished Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltvDstngshdNm")]
    #endif
    [IsoXmlTag("RltvDstngshdNm")]
    public ValueList<RelativeDistinguishedName1> RelativeDistinguishedName { get; init; } = new ValueList<RelativeDistinguishedName1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SxIvsAEcEeCQm6a_G2yO_w_1329577257
    
    
    #nullable disable
    
}
