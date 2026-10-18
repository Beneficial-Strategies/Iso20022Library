// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction6"/>
[IsoId("_TElJUtp-Ed-ak6NoX_4Aeg_-1931069201")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction6
{
    /// <inheritdoc cref="IDirectDebitTransaction6.MandateRelatedInformation"/>
    [IsoId("_TElJU9p-Ed-ak6NoX_4Aeg_-1931068769")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation6? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction6.CreditorSchemeIdentification"/>
    [IsoId("_TElJVNp-Ed-ak6NoX_4Aeg_-1931069047")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification32? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction6.PreNotificationIdentification"/>
    [IsoId("_TElJVdp-Ed-ak6NoX_4Aeg_-1931069171")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction6.PreNotificationDate"/>
    [IsoId("_TElJVtp-Ed-ak6NoX_4Aeg_-1931069140")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
