// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAcceptanceResult6"/>
[IsoId("_RBvu4dp-Ed-ak6NoX_4Aeg_2046006177")]
[DisplayName("Acceptance Result")]
public partial record AcceptanceResult6
{
    /// <inheritdoc cref="IAcceptanceResult6.Accepted"/>
    [IsoId("_RBvu4tp-Ed-ak6NoX_4Aeg_1773632231")]
    [DisplayName("Accepted")]
    [IsoXmlTag("Accptd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Accepted { get; init; }

    /// <inheritdoc cref="IAcceptanceResult6.RejectReason"/>
    [IsoId("_RBvu49p-Ed-ak6NoX_4Aeg_1929136883")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public MandateReason1Choice_? RejectReason { get; init; }

    /// <inheritdoc cref="IAcceptanceResult6.AdditionalRejectReasonInformation"/>
    [IsoId("_RBvu5Np-Ed-ak6NoX_4Aeg_-192674430")]
    [DisplayName("Additional Reject Reason Information")]
    [IsoXmlTag("AddtlRjctRsnInf")]
    public SimpleValueList<IsoMax105Text> AdditionalRejectReasonInformation { get; init; } = [];
}
