// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransaction11"/>
[IsoId("_eFalQdcZEeqRFcf2R4bPBw")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction11
{
    /// <inheritdoc cref="IDirectDebitTransaction11.MandateRelatedInformation"/>
    [IsoId("_eGwCAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation15? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction11.CreditorSchemeIdentification"/>
    [IsoId("_eGwCA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction11.PreNotificationIdentification"/>
    [IsoId("_eGwCBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransaction11.PreNotificationDate"/>
    [IsoId("_eGwCB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; }
}
