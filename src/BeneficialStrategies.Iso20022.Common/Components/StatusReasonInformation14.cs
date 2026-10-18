// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStatusReasonInformation14"/>
[IsoId("_xPVMATEyEe6g-ffJsqGiSA")]
[Description(@"Provides information on the status reason of the transaction.")]
[DisplayName("Status Reason Information14")]
public partial record StatusReasonInformation14
{
    /// <inheritdoc cref="IStatusReasonInformation14.AdditionalInformation"/>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <inheritdoc cref="IStatusReasonInformation14.Originator"/>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification272? Originator { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation14.Reason"/>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; }
}
