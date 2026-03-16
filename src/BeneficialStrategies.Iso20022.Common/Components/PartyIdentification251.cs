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
[IsoId("_IDLG6RuyEeyhRdHRjakS2w")]
[DisplayName("Party Identification")]
public record PartyIdentification251
{
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [IsoId("_IYCjlRuyEeyhRdHRjakS2w")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public required PartyIdentification229Choice_ OwnerIdentification { get; init; }

    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_IYCjnRuyEeyhRdHRjakS2w")]
    [DisplayName("LEI Identification")]
    [IsoXmlTag("LEIId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEIIdentification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_IYCjnxuyEeyhRdHRjakS2w")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification7> AlternateIdentification { get; init; } = [];

    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person&apos;s permanent home).
    /// </summary>
    [IsoId("_IYCjpxuyEeyhRdHRjakS2w")]
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; }

    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_IYCjrxuyEeyhRdHRjakS2w")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [IsoId("_IYCjtxuyEeyhRdHRjakS2w")]
    [DisplayName("Owned Securities Quantity")]
    [IsoXmlTag("OwndSctiesQty")]
    public required FinancialInstrumentQuantity33Choice_ OwnedSecuritiesQuantity { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_IYCjvxuyEeyhRdHRjakS2w")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public ValueList<BeneficiaryCertificationType10Choice_> CertificationType { get; init; } = [];

    /// <summary>
    /// Requested percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_IYCjxxuyEeyhRdHRjakS2w")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_IYCjyRuyEeyhRdHRjakS2w")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public SimpleValueList<IsoMax350Text> CertificationBreakdown { get; init; } = [];
}
