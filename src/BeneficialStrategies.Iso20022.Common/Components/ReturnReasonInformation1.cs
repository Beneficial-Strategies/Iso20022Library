// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReturnReasonInformation1"/>
[IsoId("_TPKBpdp-Ed-ak6NoX_4Aeg_2976420")]
[DisplayName("Return Reason Information")]
public partial record ReturnReasonInformation1
{
    /// <inheritdoc cref="IReturnReasonInformation1.ReturnOriginator"/>
    [IsoId("_TPKBptp-Ed-ak6NoX_4Aeg_1003149399")]
    [DisplayName("Return Originator")]
    [IsoXmlTag("RtrOrgtr")]
    public PartyIdentification8? ReturnOriginator { get; init; }

    /// <inheritdoc cref="IReturnReasonInformation1.ReturnReason"/>
    [IsoId("_TPKBp9p-Ed-ak6NoX_4Aeg_515527494")]
    [DisplayName("Return Reason")]
    [IsoXmlTag("RtrRsn")]
    public ReturnReason1Choice_? ReturnReason { get; init; }

    /// <inheritdoc cref="IReturnReasonInformation1.AdditionalReturnReasonInformation"/>
    [IsoId("_TPKBqNp-Ed-ak6NoX_4Aeg_84246003")]
    [DisplayName("Additional Return Reason Information")]
    [IsoXmlTag("AddtlRtrRsnInf")]
    public SimpleValueList<IsoMax105Text> AdditionalReturnReasonInformation { get; init; } = [];
}
