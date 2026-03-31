// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Profile of the customer selected by an ATM.
/// </summary>
[IsoId("_Okqn8Yp3EeS3NqNpgnMh2w")]
[DisplayName("ATM Customer Profile")]
public record ATMCustomerProfile2
{
    /// <summary>
    /// Reference of the customer profile.
    /// </summary>
    [IsoId("_OxCQA4p3EeS3NqNpgnMh2w")]
    [DisplayName("Profile Reference")]
    [IsoXmlTag("PrflRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProfileReference { get; init; }

    /// <summary>
    /// Identification of the customer for the bank.
    /// </summary>
    [IsoId("_OxCQBYp3EeS3NqNpgnMh2w")]
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerIdentification { get; init; }
}
