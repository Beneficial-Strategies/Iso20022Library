// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing the identification of a message.
/// </summary>
[IsoId("_RUE1Bdp-Ed-ak6NoX_4Aeg_-806411710")]
[DisplayName("Message Identification")]
public partial record MessageIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the message name identifier of the message that will be used to provide additional details.
    /// </summary>
    [IsoId("_RUE1Btp-Ed-ak6NoX_4Aeg_-705747842")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the identification of the message that will be used to provide additional details.
    /// </summary>
    [IsoId("_RUE1B9p-Ed-ak6NoX_4Aeg_-705747860")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; } 
    
    
    #nullable disable
    
}
