// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction12"/>
[IsoId("_wuFgITEyEe6g-ffJsqGiSA")]
[Description(@"Provides further specific details on the direct debit transaction and the related mandate.")]
[DisplayName("Direct Debit Transaction12")]
public partial record DirectDebitTransaction12
{
    /// <inheritdoc cref="IDirectDebitTransaction12.CreditorSchemeIdentification"/>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction12.MandateRelatedInformation"/>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation16? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction12.PreNotificationDate"/>
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    public IsoISODate? PreNotificationDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction12.PreNotificationIdentification"/>
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    public IsoMax35Text? PreNotificationIdentification { get; init; }
}
