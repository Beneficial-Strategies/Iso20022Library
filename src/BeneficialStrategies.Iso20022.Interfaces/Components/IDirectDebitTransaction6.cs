// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide specific information on the direct debit transaction and the related mandate.
/// </summary>
[IsoId("_TElJUtp-Ed-ak6NoX_4Aeg_-1931069201")]
public interface IDirectDebitTransaction6 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to provide further details of the direct debit mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_TElJU9p-Ed-ak6NoX_4Aeg_-1931068769")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    IMandateRelatedInformation6? MandateRelatedInformation { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_TElJVNp-Ed-ak6NoX_4Aeg_-1931069047")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification32? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.||Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [IsoId("_TElJVdp-Ed-ak6NoX_4Aeg_-1931069171")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    IsoMax35Text? PreNotificationIdentification { get; }

    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor&apos;s agent.
    /// </summary>
    [IsoId("_TElJVtp-Ed-ak6NoX_4Aeg_-1931069140")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    IsoISODate? PreNotificationDate { get; }
}
