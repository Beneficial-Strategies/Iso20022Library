// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of information identifying the reporting counterparty.
/// </summary>
[IsoId("_CSkJq8gtEeuGrNSsxk3B0A")]
[DisplayName("Counterparty Identification")]
public record CounterpartyIdentification10
{
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_CT9308gtEeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OrganisationIdentification15Choice_? Identification { get; init; }

    /// <summary>
    /// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
    /// </summary>
    [IsoId("_CT931cgtEeuGrNSsxk3B0A")]
    [DisplayName("Side")]
    [IsoXmlTag("Sd")]
    public CollateralRole1Code? Side { get; init; }
}
