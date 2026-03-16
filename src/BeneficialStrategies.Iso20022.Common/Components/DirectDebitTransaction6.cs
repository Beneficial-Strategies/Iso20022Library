// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide specific information on the direct debit transaction and the related mandate.
/// </summary>
[IsoId("_TElJUtp-Ed-ak6NoX_4Aeg_-1931069201")]
[DisplayName("Direct Debit Transaction")]
public record DirectDebitTransaction6
{
    /// <summary>
    /// Set of elements used to provide further details of the direct debit mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_TElJU9p-Ed-ak6NoX_4Aeg_-1931068769")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation6? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_TElJVNp-Ed-ak6NoX_4Aeg_-1931069047")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification32? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.||Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [IsoId("_TElJVdp-Ed-ak6NoX_4Aeg_-1931069171")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor&apos;s agent.
    /// </summary>
    [IsoId("_TElJVtp-Ed-ak6NoX_4Aeg_-1931069140")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
