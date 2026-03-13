// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information concerning the technical error that prevented delivery of the referenced messaging by the payment gateway application.
/// </summary>
[IsoId("_-CoNsw23EeWH49U6bkyMaA")]
[DisplayName("Technical Error")]
public partial record TechnicalError1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the severity of the related error.
    /// </summary>
    [IsoId("_DP8UMg3FEeWH49U6bkyMaA")]
    [DisplayName("Severity")]
    [IsoXmlTag("svrty")]
    public required ErrorSeverity1Code Severity { get; init; } 
    
    /// <summary>
    /// Specifies the error code.
    /// </summary>
    [IsoId("_qpz94A3CEeWH49U6bkyMaA")]
    [DisplayName("Error Code")]
    [IsoXmlTag("ErrCd")]
    public required TechnicalError1Choice_ ErrorCode { get; init; } 
    
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    [IsoId("_-CoNtA23EeWH49U6bkyMaA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    public SimpleValueList<System.String> Description { get; init; } = [];
    // ID for the above is _-CoNtA23EeWH49U6bkyMaA
    
    
    #nullable disable
    
}
