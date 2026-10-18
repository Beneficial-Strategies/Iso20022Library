// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction9"/>
[IsoId("_s3kkUWk2Eeanu6HLe77Rkg")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction9
{
    /// <inheritdoc cref="IDirectDebitTransaction9.MandateRelatedInformation"/>
    [IsoId("_tAWFc2k2Eeanu6HLe77Rkg")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation11? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction9.CreditorSchemeIdentification"/>
    [IsoId("_tAWFdWk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction9.PreNotificationIdentification"/>
    [IsoId("_tAWFd2k2Eeanu6HLe77Rkg")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction9.PreNotificationDate"/>
    [IsoId("_tAWFeWk2Eeanu6HLe77Rkg")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
