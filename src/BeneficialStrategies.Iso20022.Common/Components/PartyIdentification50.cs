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
[IsoId("_gOYtfeaNEd-q8fx_Zl_34A")]
[DisplayName("Party Identification")]
public record PartyIdentification50
{
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [IsoId("_gOYtf-aNEd-q8fx_Zl_34A")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public required PartyIdentification48Choice_ OwnerIdentification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_gOYtgeaNEd-q8fx_Zl_34A")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification2> AlternateIdentification { get; init; } = [];

    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a persons permanent home).
    /// </summary>
    [IsoId("_gOYtg-aNEd-q8fx_Zl_34A")]
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; }

    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_gOYtheaNEd-q8fx_Zl_34A")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [IsoId("_gOYth-aNEd-q8fx_Zl_34A")]
    [DisplayName("Owned Securities Quantity")]
    [IsoXmlTag("OwndSctiesQty")]
    public required FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_gOYtieaNEd-q8fx_Zl_34A")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public ValueList<BeneficiaryCertificationType2Choice_> CertificationType { get; init; } = [];

    /// <summary>
    /// Provides details relative to the beneficial owner not included within structured fields of this message.
    /// </summary>
    [IsoId("_gOYti-aNEd-q8fx_Zl_34A")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? DeclarationDetails { get; init; }
}
