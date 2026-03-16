// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Verification7.
/// </summary>
[IsoId("_TY1DAXjTEe6YlIMyoxWMJA")]
[DisplayName("Verification7")]
public partial record Verification7
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax35Text? AdditionalInformation { get; init; } 

    /// <summary>
    /// Entity.
    /// </summary>
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public VerificationEntity2Code? Entity { get; init; } 

    /// <summary>
    /// Other Entity.
    /// </summary>
    [DisplayName("Other Entity")]
    [IsoXmlTag("OthrNtty")]
    public IsoMax35Text? OtherEntity { get; init; } 

    /// <summary>
    /// Other Result.
    /// </summary>
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    public IsoMax500Text? OtherResult { get; init; } 

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; } 

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification3Code? Result { get; init; } 

    /// <summary>
    /// Result Details.
    /// </summary>
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public ValueList<AdditionalData1> ResultDetails { get; init; } = [];

    /// <summary>
    /// Sub Type.
    /// </summary>
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalAuthenticationMethod1Code? Type { get; init; } 

    
    #nullable disable
    
}
