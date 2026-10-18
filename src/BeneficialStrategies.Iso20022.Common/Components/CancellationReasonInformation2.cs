// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICancellationReasonInformation2"/>
[IsoId("_TOt8yNp-Ed-ak6NoX_4Aeg_993731779")]
[DisplayName("Cancellation Reason Information")]
public partial record CancellationReasonInformation2
{
    /// <inheritdoc cref="ICancellationReasonInformation2.Originator"/>
    [IsoId("_TO3GsNp-Ed-ak6NoX_4Aeg_-102160306")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; }

    /// <inheritdoc cref="ICancellationReasonInformation2.Reason"/>
    [IsoId("_TO3Gsdp-Ed-ak6NoX_4Aeg_-190159100")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <inheritdoc cref="ICancellationReasonInformation2.AdditionalInformation"/>
    [IsoId("_TO3Gstp-Ed-ak6NoX_4Aeg_256167406")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
