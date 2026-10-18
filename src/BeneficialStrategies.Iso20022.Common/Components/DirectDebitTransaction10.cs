// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction10"/>
[IsoId("_KgsVmW49EeiU9cctagi5ow")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction10
{
    /// <inheritdoc cref="IDirectDebitTransaction10.MandateRelatedInformation"/>
    [IsoId("_Kp7xA249EeiU9cctagi5ow")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation14? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction10.CreditorSchemeIdentification"/>
    [IsoId("_Kp7xBW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction10.PreNotificationIdentification"/>
    [IsoId("_Kp7xB249EeiU9cctagi5ow")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction10.PreNotificationDate"/>
    [IsoId("_Kp7xCW49EeiU9cctagi5ow")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
