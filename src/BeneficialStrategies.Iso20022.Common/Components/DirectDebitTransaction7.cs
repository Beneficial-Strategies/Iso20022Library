// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction7"/>
[IsoId("_teOIFFkyEeGeoaLUQk__nA_-44186302")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction7
{
    /// <inheritdoc cref="IDirectDebitTransaction7.MandateRelatedInformation"/>
    [IsoId("_teX5EFkyEeGeoaLUQk__nA_1642774080")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation8? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction7.CreditorSchemeIdentification"/>
    [IsoId("_teX5EVkyEeGeoaLUQk__nA_-507772793")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction7.PreNotificationIdentification"/>
    [IsoId("_teX5ElkyEeGeoaLUQk__nA_63774911")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction7.PreNotificationDate"/>
    [IsoId("_teX5E1kyEeGeoaLUQk__nA_-1935083170")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
