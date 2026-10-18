// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction1"/>
[IsoId("_TEIdZNp-Ed-ak6NoX_4Aeg_-328923835")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction1
{
    /// <inheritdoc cref="IDirectDebitTransaction1.MandateRelatedInformation"/>
    [IsoId("_TEIdZdp-Ed-ak6NoX_4Aeg_-89731386")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction1.CreditorSchemeIdentification"/>
    [IsoId("_TEIdZtp-Ed-ak6NoX_4Aeg_-88808758")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification8? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction1.PreNotificationIdentification"/>
    [IsoId("_TEIdZ9p-Ed-ak6NoX_4Aeg_-328922905")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction1.PreNotificationDate"/>
    [IsoId("_TEIdaNp-Ed-ak6NoX_4Aeg_-89732436")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
