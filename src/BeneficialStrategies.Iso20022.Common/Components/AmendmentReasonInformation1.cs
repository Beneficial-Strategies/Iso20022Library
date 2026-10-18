// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentReasonInformation1"/>
[IsoId("_TOt8wdp-Ed-ak6NoX_4Aeg_-588729591")]
[DisplayName("Amendment Reason Information")]
public partial record AmendmentReasonInformation1
{
    /// <inheritdoc cref="IAmendmentReasonInformation1.Originator"/>
    [IsoId("_TOt8wtp-Ed-ak6NoX_4Aeg_-1482635343")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; }

    /// <inheritdoc cref="IAmendmentReasonInformation1.Reason"/>
    [IsoId("_TOt8w9p-Ed-ak6NoX_4Aeg_640498191")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <inheritdoc cref="IAmendmentReasonInformation1.AdditionalInformation"/>
    [IsoId("_TOt8xNp-Ed-ak6NoX_4Aeg_-1877900838")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
