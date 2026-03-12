// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains credential information.
/// </summary>
[IsoId("_AwRLkMV4Eee3gsS0IxDWIA")]
[DisplayName("Credentials")]
public partial record Credentials1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the type of credential.
    /// </summary>
    [IsoId("_OEL4sMV4Eee3gsS0IxDWIA")]
    [DisplayName("Identification Code")]
    [IsoXmlTag("IdCd")]
    public required Identification2Code IdentificationCode { get; init; } 
    
    /// <summary>
    /// Used when OtherNational or OtherPrivate value is selected in identification code list. 
    /// </summary>
    [IsoId("_tNXSEJcVEeme5LKU36W8xA")]
    [DisplayName("Other Identification Code")]
    [IsoXmlTag("OthrIdCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherIdentificationCode { get; init; } 
    
    /// <summary>
    /// Value of identification.
    /// </summary>
    [IsoId("_UR2U0MV4Eee3gsS0IxDWIA")]
    [DisplayName("Identification Value")]
    [IsoXmlTag("IdVal")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text IdentificationValue { get; init; } 
    
    
    #nullable disable
    
}
