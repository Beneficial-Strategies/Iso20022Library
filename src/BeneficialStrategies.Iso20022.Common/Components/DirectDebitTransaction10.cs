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
[IsoId("_KgsVmW49EeiU9cctagi5ow")]
[DisplayName("Direct Debit Transaction")]
public record DirectDebitTransaction10
{
    /// <summary>
    /// Provides further details of the direct debit mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_Kp7xA249EeiU9cctagi5ow")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation14? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_Kp7xBW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.||Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [IsoId("_Kp7xB249EeiU9cctagi5ow")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor&apos;s agent.
    /// </summary>
    [IsoId("_Kp7xCW49EeiU9cctagi5ow")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
