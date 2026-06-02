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
[IsoId("fdf0da35-dba2-4eaa-8e8c-28edb3a46597")]
[DisplayName("Account Identification And Name8")]
public record AccountIdentificationAndName8
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("119d1111-6777-4ffd-9df4-1a61ad959a9a")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification82Choice Identification { get; init; }

    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("07f13c86-9616-439b-aa87-5823246c058b")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax35Text? Name { get; init; }
}
