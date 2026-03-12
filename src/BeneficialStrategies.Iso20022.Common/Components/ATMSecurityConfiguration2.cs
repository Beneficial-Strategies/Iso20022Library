// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration of the cryptographic keys.
/// </summary>
[IsoId("_Di0fIYr7EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
public partial record ATMSecurityConfiguration2
{
    #nullable enable
    
    /// <summary>
    /// Maximum number of symmetric keys the security module is able to manage.
    /// </summary>
    [IsoId("_QbPjEIr7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Symmetric Key")]
    [IsoXmlTag("MaxSmmtrcKey")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumSymmetricKey { get; init; } 
    
    /// <summary>
    /// Maximum number of asymmetric keys the security module is able to manage.
    /// </summary>
    [IsoId("_T46j0Ir7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Asymmetric Key")]
    [IsoXmlTag("MaxAsmmtrcKey")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumAsymmetricKey { get; init; } 
    
    /// <summary>
    /// Maximum RSA key length (in number of bytes), the security module is able to manage.
    /// </summary>
    [IsoId("_XJMBwIr7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum RSA Key Length")]
    [IsoXmlTag("MaxRSAKeyLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumRSAKeyLength { get; init; } 
    
    /// <summary>
    /// Maximum RSA root key length (in number of bytes), the security module is able to manage, if different from the maximum RSA key length.
    /// </summary>
    [IsoId("_acT_YIr7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Root Key Length")]
    [IsoXmlTag("MaxRootKeyLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumRootKeyLength { get; init; } 
    
    
    #nullable disable
    
}
