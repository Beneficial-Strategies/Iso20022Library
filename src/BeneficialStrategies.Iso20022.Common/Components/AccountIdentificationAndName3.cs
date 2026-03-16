// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the account expressed with a name and an account number.
/// </summary>
[IsoId("_PopN8dp-Ed-ak6NoX_4Aeg_1404214136")]
[DisplayName("Account Identification And Name")]
public record AccountIdentificationAndName3
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_PopN8tp-Ed-ak6NoX_4Aeg_1404216342")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccountIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_PopN89p-Ed-ak6NoX_4Aeg_1404216074")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }
}
