// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Profile of the customer with the allowed services and restrictions.
/// </summary>
[IsoId("_el4xkYqzEeSIDtZ76p6McQ")]
[DisplayName("ATM Customer Profile")]
public partial record ATMCustomerProfile3
{
    #nullable enable
    
    /// <summary>
    /// Reference of the customer profile.
    /// </summary>
    [IsoId("_eyuTsYqzEeSIDtZ76p6McQ")]
    [DisplayName("Profile Reference")]
    [IsoXmlTag("PrflRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProfileReference { get; init; } 
    
    /// <summary>
    /// Identification of the customer for the bank.
    /// </summary>
    [IsoId("_eyuTs4qzEeSIDtZ76p6McQ")]
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CustomerIdentification { get; init; } 
    
    /// <summary>
    /// Description of the customer&apos;s profile in plaintext.
    /// </summary>
    [IsoId("_4iZ98IqzEeSIDtZ76p6McQ")]
    [DisplayName("Profile Description")]
    [IsoXmlTag("PrflDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ProfileDescription { get; init; } 
    
    /// <summary>
    /// Services allowed for the customer&apos;s profile.
    /// </summary>
    [IsoId("_ShKmAIq0EeSIDtZ76p6McQ")]
    [DisplayName("Allowed Services")]
    [IsoXmlTag("AllwdSvcs")]
    public ATMService7? AllowedServices { get; init; } 
    
    
    #nullable disable
    
}
