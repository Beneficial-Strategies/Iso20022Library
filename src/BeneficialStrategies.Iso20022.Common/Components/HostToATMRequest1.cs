// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request to an ATM to contact the ATM manager.
/// </summary>
[IsoId("_nkIKwItqEeSDLd7nI4Quzw")]
[DisplayName("Host To ATM Request")]
public partial record HostToATMRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_FLX8cItrEeSDLd7nI4Quzw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment9 Environment { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_DovRwCydEeWT0qwwEKj7sA")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    /// <summary>
    /// Message that have to be sent by the ATM.
    /// </summary>
    [IsoId("_WvQl0CvQEeW-qbryg71zJw")]
    [DisplayName("Expected Message Function")]
    [IsoXmlTag("XpctdMsgFctn")]
    public required MessageFunction8Code ExpectedMessageFunction { get; init; } 
    
    
    #nullable disable
    
}
