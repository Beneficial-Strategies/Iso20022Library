// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Direct Debit Transaction12.
/// </summary>
[IsoId("_wuFgITEyEe6g-ffJsqGiSA")]
[DisplayName("Direct Debit Transaction12")]
public record DirectDebitTransaction12
{
    /// <summary>
    /// Creditor Scheme Identification.
    /// </summary>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Mandate Related Information.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation16? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Pre Notification Date.
    /// </summary>
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    public IsoISODate? PreNotificationDate { get; init; }

    /// <summary>
    /// Pre Notification Identification.
    /// </summary>
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    public IsoMax35Text? PreNotificationIdentification { get; init; }
}
