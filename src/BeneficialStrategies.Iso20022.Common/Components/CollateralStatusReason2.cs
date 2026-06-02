// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business status of the collateral data management request for processing in the system.
/// </summary>
[IsoId("_a6cf4aktEeynsLtPxJMJTQ")]
[DisplayName("Collateral Status Reason2")]
public record CollateralStatusReason2
{
    /// <summary>
    /// Status of the collateral data maintenance instruction.
    /// </summary>
    [IsoId("_bBmQw6ktEeynsLtPxJMJTQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status10Code Status { get; init; }

    /// <summary>
    /// Reason for the status of a collateral data maintenance instruction.
    /// </summary>
    [IsoId("_bBmQxaktEeynsLtPxJMJTQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<StatusReasonInformation13> Reason { get; init; } = [];

    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_DQJJkKk0EeynsLtPxJMJTQ")]
    [DisplayName("Eligibility Set Profile")]
    [IsoXmlTag("ElgbltySetPrfl")]
    public GenericIdentification1? EligibilitySetProfile { get; init; }
}
