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
[IsoId("_qY-pLPfREeiNZp_PtLohLw")]
[DisplayName("Party Identification")]
public record PartyIdentification154
{
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [IsoId("_qY-pMvfREeiNZp_PtLohLw")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public required PartyIdentification137Choice_ OwnerIdentification { get; init; }

    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_qY-pOvfREeiNZp_PtLohLw")]
    [DisplayName("LEI Identification")]
    [IsoXmlTag("LEIId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEIIdentification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_qY-pPPfREeiNZp_PtLohLw")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification9> AlternateIdentification { get; init; } = [];

    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person&apos;s permanent home).
    /// </summary>
    [IsoId("_qY-pRPfREeiNZp_PtLohLw")]
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; }

    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_qY-pTPfREeiNZp_PtLohLw")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [IsoId("_qY-pVPfREeiNZp_PtLohLw")]
    [DisplayName("Owned Securities Quantity")]
    [IsoXmlTag("OwndSctiesQty")]
    public required FinancialInstrumentQuantity15Choice_ OwnedSecuritiesQuantity { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_qY-pXPfREeiNZp_PtLohLw")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public ValueList<BeneficiaryCertificationType11Choice_> CertificationType { get; init; } = [];

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_qY-pZPfREeiNZp_PtLohLw")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? CertificationBreakdown { get; init; }
}
