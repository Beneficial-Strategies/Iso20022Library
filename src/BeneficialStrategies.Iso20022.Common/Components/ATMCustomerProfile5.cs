// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Profile of the customer with the allowed services and restrictions.
/// </summary>
[IsoId("_QLIOwa4XEeW_TaP-ygI0SQ")]
[DisplayName("ATM Customer Profile")]
public record ATMCustomerProfile5
{
    /// <summary>
    /// Reference of the customer profile.
    /// </summary>
    [IsoId("_QXf20a4XEeW_TaP-ygI0SQ")]
    [DisplayName("Profile Reference")]
    [IsoXmlTag("PrflRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProfileReference { get; init; }

    /// <summary>
    /// Identification of the customer for the bank.
    /// </summary>
    [IsoId("_QXf2064XEeW_TaP-ygI0SQ")]
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerIdentification { get; init; }

    /// <summary>
    /// Description of the customer&apos;s profile in plaintext.
    /// </summary>
    [IsoId("_QXf21a4XEeW_TaP-ygI0SQ")]
    [DisplayName("Profile Description")]
    [IsoXmlTag("PrflDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ProfileDescription { get; init; }

    /// <summary>
    /// Services allowed for the customer&apos;s profile.
    /// </summary>
    [IsoId("_QXf2164XEeW_TaP-ygI0SQ")]
    [DisplayName("Allowed Services")]
    [IsoXmlTag("AllwdSvcs")]
    public ATMService17? AllowedServices { get; init; }
}
