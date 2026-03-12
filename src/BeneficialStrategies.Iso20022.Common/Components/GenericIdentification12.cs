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
[IsoId("_QAoQItp-Ed-ak6NoX_4Aeg_405963943")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification12
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_QAoQI9p-Ed-ak6NoX_4Aeg_405963945")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_QAoQJNp-Ed-ak6NoX_4Aeg_405964004")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    /// <summary>
    /// Type of other identification.
    /// </summary>
    [IsoId("_QAoQJdp-Ed-ak6NoX_4Aeg_977624326")]
    [DisplayName("Other Identification Type")]
    [IsoXmlTag("OthrIdTp")]
    public IdentificationType1Choice_? OtherIdentificationType { get; init; } 
    
    
    #nullable disable
    
}
