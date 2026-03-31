// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the beneficial owner of the securities.
/// </summary>
[IsoId("_chc-k5KQEeWHWpTQn1FFVg")]
[DisplayName("Party Identification")]
public record PartyIdentification101
{
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [IsoId("_chc-l5KQEeWHWpTQn1FFVg")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public required PartyIdentification104Choice_ OwnerIdentification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_chc-n5KQEeWHWpTQn1FFVg")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification9> AlternateIdentification { get; init; } = [];

    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a persons permanent home).
    /// </summary>
    [IsoId("_chc-p5KQEeWHWpTQn1FFVg")]
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; }

    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_chc-r5KQEeWHWpTQn1FFVg")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [IsoId("_chc-t5KQEeWHWpTQn1FFVg")]
    [DisplayName("Owned Securities Quantity")]
    [IsoXmlTag("OwndSctiesQty")]
    public required FinancialInstrumentQuantity15Choice_ OwnedSecuritiesQuantity { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_chc-v5KQEeWHWpTQn1FFVg")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public ValueList<BeneficiaryCertificationType11Choice_> CertificationType { get; init; } = [];

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_chc-x5KQEeWHWpTQn1FFVg")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? CertificationBreakdown { get; init; }
}
