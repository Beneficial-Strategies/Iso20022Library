// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further specific details on the direct debit transaction and the related mandate.
/// </summary>
[IsoId("_s3kkUWk2Eeanu6HLe77Rkg")]
public interface IDirectDebitTransaction9 : IIsoComponent
{
    /// <summary>
    /// Provides further details of the direct debit mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_tAWFc2k2Eeanu6HLe77Rkg")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    IMandateRelatedInformation11? MandateRelatedInformation { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_tAWFdWk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification43? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.||Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [IsoId("_tAWFd2k2Eeanu6HLe77Rkg")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    Max35Text? PreNotificationIdentification { get; }

    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor&apos;s agent.
    /// </summary>
    [IsoId("_tAWFeWk2Eeanu6HLe77Rkg")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    ISODate? PreNotificationDate { get; }
}
