// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further specific details on the direct debit transaction and the related mandate.
/// </summary>
[IsoId("_wuFgITEyEe6g-ffJsqGiSA")]
[Description(@"Provides further specific details on the direct debit transaction and the related mandate.")]
[DisplayName("Direct Debit Transaction12")]
public record DirectDebitTransaction12
{
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Provides further details of the direct debit mandate signed between the creditor and the debtor.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation16? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor's agent.
    /// </summary>
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    public IsoISODate? PreNotificationDate { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.
    /// Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    public IsoMax35Text? PreNotificationIdentification { get; init; }
}
