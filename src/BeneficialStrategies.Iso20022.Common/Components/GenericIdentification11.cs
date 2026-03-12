// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, eg, party identification or account identification.
/// </summary>
[IsoId("_QAVVOdp-Ed-ak6NoX_4Aeg_-2099297654")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification11
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_QAVVOtp-Ed-ak6NoX_4Aeg_-2099297636")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the identifier.
    /// </summary>
    [IsoId("_QAVVO9p-Ed-ak6NoX_4Aeg_-2099297619")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required PersonIdentificationType2Code IdentificationType { get; init; } 
    
    /// <summary>
    /// Specifies a type of individual identification.
    /// </summary>
    [IsoId("_QAfGMNp-Ed-ak6NoX_4Aeg_-749110044")]
    [DisplayName("Extended Identification Type")]
    [IsoXmlTag("XtndedIdTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedIdentificationType { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_QAfGMdp-Ed-ak6NoX_4Aeg_-2099297601")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
