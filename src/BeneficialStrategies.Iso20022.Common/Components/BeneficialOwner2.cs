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
[IsoId("_vfLMYbv-EeOgOuxYpBEzKg")]
[DisplayName("Beneficial Owner")]
public record BeneficialOwner2
{
    /// <summary>
    /// Identification of the party that is the beneficial owner of the specified financial instrument.
    /// </summary>
    [IsoId("_vq8-kbv-EeOgOuxYpBEzKg")]
    [DisplayName("Beneficial Owner Identification")]
    [IsoXmlTag("BnfclOwnrId")]
    public required PartyIdentification100 BeneficialOwnerIdentification { get; init; }

    /// <summary>
    /// Additional identification of the party that is the beneficial owner of the specified financial instrument.
    /// </summary>
    [IsoId("_vq8-k7v-EeOgOuxYpBEzKg")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public AlternateIdentification4? AdditionalIdentification { get; init; }

    /// <summary>
    /// Nationality of the beneficial owner.
    /// </summary>
    [IsoId("_vq8-lbv-EeOgOuxYpBEzKg")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; }

    /// <summary>
    /// Country in which the person is permanently domiciled (the place of a person&apos;s permanent home).
    /// </summary>
    [IsoId("_vq8-l7v-EeOgOuxYpBEzKg")]
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; }

    /// <summary>
    /// Country for which the holder of the financial instrument must specify that it is not domiciled. (The holder must certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.).
    /// </summary>
    [IsoId("_vq8-mbv-EeOgOuxYpBEzKg")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public CountryCode? NonDomicileCountry { get; init; }

    /// <summary>
    /// Indicates whether certification is required from the account owner. (Yes means that certification is required. No means certification is not required.).
    /// </summary>
    [IsoId("_vq8-m7v-EeOgOuxYpBEzKg")]
    [DisplayName("Certification Indicator")]
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationIndicator { get; init; }

    /// <summary>
    /// Type of beneficial owner certification that is required.
    /// </summary>
    [IsoId("_vq8-nbv-EeOgOuxYpBEzKg")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public BeneficiaryCertificationType9Choice_? CertificationType { get; init; }

    /// <summary>
    /// Declaration details related to the financial instrument, for example, beneficial ownership.
    /// </summary>
    [IsoId("_vq8-n7v-EeOgOuxYpBEzKg")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? DeclarationDetails { get; init; }
}
