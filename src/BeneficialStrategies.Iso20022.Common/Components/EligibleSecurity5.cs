// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the eligible securities as defined in the collateral reference data.
/// </summary>
[IsoId("_vG-yEbDEEe-g3p7goNrabg")]
[DisplayName("Eligible Security5")]
public record EligibleSecurity5
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_vMPFgbDEEe-g3p7goNrabg")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [MinLength(1)]
    public ValueList<SecurityIdentification19> SecurityIdentification { get; init; } = [];

    /// <summary>
    /// Currency which may be processed by the system.
    /// </summary>
    [IsoId("_vMPFg7DEEe-g3p7goNrabg")]
    [DisplayName("Collateralisation Currency")]
    [IsoXmlTag("CollstnCcy")]
    public ActiveOrHistoricCurrencyCode? CollateralisationCurrency { get; init; }

    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_vMPFhbDEEe-g3p7goNrabg")]
    [DisplayName("Eligibility Set Profile")]
    [IsoXmlTag("ElgbltySetPrfl")]
    public GenericIdentification1? EligibilitySetProfile { get; init; }

    /// <summary>
    /// Identifies the party for which the eligible security is defined.
    /// </summary>
    [IsoId("_vMPFh7DEEe-g3p7goNrabg")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification2Choice PartyIdentification { get; init; }
}
