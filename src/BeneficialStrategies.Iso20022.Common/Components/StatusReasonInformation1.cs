// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStatusReasonInformation1"/>
[IsoId("_TPA3stp-Ed-ak6NoX_4Aeg_-1001293915")]
[DisplayName("Status Reason Information")]
public partial record StatusReasonInformation1
{
    /// <inheritdoc cref="IStatusReasonInformation1.StatusOriginator"/>
    [IsoId("_TPA3s9p-Ed-ak6NoX_4Aeg_-1001293584")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    public PartyIdentification8? StatusOriginator { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation1.StatusReason"/>
    [IsoId("_TPA3tNp-Ed-ak6NoX_4Aeg_-1001293862")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReason1Choice_? StatusReason { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation1.AdditionalStatusReasonInformation"/>
    [IsoId("_TPA3tdp-Ed-ak6NoX_4Aeg_-80545028")]
    [DisplayName("Additional Status Reason Information")]
    [IsoXmlTag("AddtlStsRsnInf")]
    public SimpleValueList<IsoMax105Text> AdditionalStatusReasonInformation { get; init; } = [];
}
