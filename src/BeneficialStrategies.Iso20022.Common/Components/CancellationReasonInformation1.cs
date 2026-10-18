// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICancellationReasonInformation1"/>
[IsoId("_TO3Gttp-Ed-ak6NoX_4Aeg_-436227161")]
[DisplayName("Cancellation Reason Information")]
public partial record CancellationReasonInformation1
{
    /// <inheritdoc cref="ICancellationReasonInformation1.CancellationOriginator"/>
    [IsoId("_TO3Gt9p-Ed-ak6NoX_4Aeg_-436226813")]
    [DisplayName("Cancellation Originator")]
    [IsoXmlTag("CxlOrgtr")]
    public PartyIdentification8? CancellationOriginator { get; init; }

    /// <inheritdoc cref="ICancellationReasonInformation1.CancellationReason"/>
    [IsoId("_TPA3sNp-Ed-ak6NoX_4Aeg_-436226866")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public CancellationReason1Choice_? CancellationReason { get; init; }

    /// <inheritdoc cref="ICancellationReasonInformation1.AdditionalCancellationReasonInformation"/>
    [IsoId("_TPA3sdp-Ed-ak6NoX_4Aeg_-436227125")]
    [DisplayName("Additional Cancellation Reason Information")]
    [IsoXmlTag("AddtlCxlRsnInf")]
    public SimpleValueList<IsoMax105Text> AdditionalCancellationReasonInformation { get; init; } =
        [];
}
