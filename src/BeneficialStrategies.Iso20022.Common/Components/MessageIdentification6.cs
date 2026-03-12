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
[IsoId("_jHt68e5NEeCisYr99QEiWA_-1542843714")]
[DisplayName("Message Identification")]
public partial record MessageIdentification6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the message name identifier of the referenced message.
    /// </summary>
    [IsoId("_jHt68u5NEeCisYr99QEiWA_-1385597029")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the identification of the referenced message.
    /// </summary>
    [IsoId("_jHt68-5NEeCisYr99QEiWA_-942608537")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; } 
    
    
    #nullable disable
    
}
