// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further specific details on the direct debit transaction and the related mandate.
/// </summary>
[IsoId("_wuFgITEyEe6g-ffJsqGiSA")]
public interface IDirectDebitTransaction12 : IIsoComponent
{
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification272? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Provides further details of the direct debit mandate signed between the creditor and the debtor.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    IMandateRelatedInformation16? MandateRelatedInformation { get; }

    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor's agent.
    /// </summary>
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    IsoISODate? PreNotificationDate { get; }

    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.
    /// Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    IsoMax35Text? PreNotificationIdentification { get; }
}
