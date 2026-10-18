// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction8"/>
[IsoId("_nP8bhx72EeSxevWRRWxNAg")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction8
{
    /// <inheritdoc cref="IDirectDebitTransaction8.MandateRelatedInformation"/>
    [IsoId("_niQTcx72EeSxevWRRWxNAg")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation10? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction8.CreditorSchemeIdentification"/>
    [IsoId("_niQTdR72EeSxevWRRWxNAg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction8.PreNotificationIdentification"/>
    [IsoId("_niQTdx72EeSxevWRRWxNAg")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction8.PreNotificationDate"/>
    [IsoId("_niQTeR72EeSxevWRRWxNAg")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
