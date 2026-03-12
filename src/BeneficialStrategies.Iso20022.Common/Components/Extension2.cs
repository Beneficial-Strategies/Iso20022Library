// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information that can not be captured in the structured fields and/or any other specific block.
/// </summary>
[IsoId("_QzJSNdp-Ed-ak6NoX_4Aeg_251191216")]
[DisplayName("Extension")]
public partial record Extension2
{
    #nullable enable
    
    /// <summary>
    /// Name qualifying the information provided in the Text field, and place where this information should be inserted.
    /// </summary>
    [IsoId("_QzJSNtp-Ed-ak6NoX_4Aeg_-1852964930")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Technical element wrapping the extension.
    /// </summary>
    [IsoId("_QzJSN9p-Ed-ak6NoX_4Aeg_-277341268")]
    [DisplayName("Extension Envelope")]
    [IsoXmlTag("XtnsnEnvlp")]
    public required ExtensionEnvelope1 ExtensionEnvelope { get; init; } 
    
    
    #nullable disable
    
}
