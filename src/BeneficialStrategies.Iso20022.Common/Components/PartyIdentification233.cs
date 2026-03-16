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
[IsoId("_FEeukeXuEemEj48jhmlA0Q")]
[DisplayName("Party Identification")]
public record PartyIdentification233
{
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [IsoId("_FWLileXuEemEj48jhmlA0Q")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public required PartyIdentification120Choice_ OwnerIdentification { get; init; }

    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_FWLineXuEemEj48jhmlA0Q")]
    [DisplayName("LEI Identification")]
    [IsoXmlTag("LEIId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEIIdentification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_FWLin-XuEemEj48jhmlA0Q")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }

    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person&apos;s permanent home).
    /// </summary>
    [IsoId("_FWLip-XuEemEj48jhmlA0Q")]
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; }

    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_FWLir-XuEemEj48jhmlA0Q")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public CountryCode? NonDomicileCountry { get; init; }

    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [IsoId("_FWLit-XuEemEj48jhmlA0Q")]
    [DisplayName("Owned Securities Quantity")]
    [IsoXmlTag("OwndSctiesQty")]
    public required FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_FWLiv-XuEemEj48jhmlA0Q")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public BeneficiaryCertificationType10Choice_? CertificationType { get; init; }

    /// <summary>
    /// Requested percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_NKqEIOXxEemEj48jhmlA0Q")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_FWLix-XuEemEj48jhmlA0Q")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? CertificationBreakdown { get; init; }
}
