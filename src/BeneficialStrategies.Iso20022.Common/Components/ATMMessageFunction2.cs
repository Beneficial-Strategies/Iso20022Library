// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// </summary>
[IsoId("_nymwQa1wEeWMg5rOByfExw")]
[DisplayName("ATM Message Function")]
public partial record ATMMessageFunction2
{
    #nullable enable
    
    /// <summary>
    /// Type of requested function.
    /// </summary>
    [IsoId("_n-hsYa1wEeWMg5rOByfExw")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public required MessageFunction11Code Function { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_n-hsY61wEeWMg5rOByfExw")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the ATM manager host.
    /// </summary>
    [IsoId("_n-hsZa1wEeWMg5rOByfExw")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; } 
    
    
    #nullable disable
    
}
