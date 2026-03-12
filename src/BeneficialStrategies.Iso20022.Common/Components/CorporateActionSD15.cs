// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains details about called certificates.
/// </summary>
[IsoId("_Jgj5IZ2NEeW-bsa36JFb9A")]
[DisplayName("Corporate Action SD")]
public partial record CorporateActionSD15
{
    #nullable enable
    
    /// <summary>
    /// Unique identification or serial number that is assigned and affixed by an issuer or transfer agent to each securities certificate.
    /// </summary>
    [IsoId("_J3BRUZ2NEeW-bsa36JFb9A")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max15AlphaNumericText)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoMax15AlphaNumericText CertificateNumber { get; init; } 
    
    /// <summary>
    /// Principal amount (for debt issues) or number of shares (for equity issues) that has been called for redemption for a particular certificate number.
    /// </summary>
    [IsoId("_J3BRWZ2NEeW-bsa36JFb9A")]
    [DisplayName("Certificate Called Amount")]
    [IsoXmlTag("CertClldAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber CertificateCalledAmount { get; init; } 
    
    
    #nullable disable
    
}
