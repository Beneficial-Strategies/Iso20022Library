// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the status reason of the transaction.
/// </summary>
[IsoId("_TPA3stp-Ed-ak6NoX_4Aeg_-1001293915")]
[DisplayName("Status Reason Information")]
public record StatusReasonInformation1
{
    /// <summary>
    /// Party issuing the status.
    /// </summary>
    [IsoId("_TPA3s9p-Ed-ak6NoX_4Aeg_-1001293584")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    public PartyIdentification8? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_TPA3tNp-Ed-ak6NoX_4Aeg_-1001293862")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReason1Choice_? StatusReason { get; init; }

    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes, e.g. to report repaired information, or to further detail the status reason.
    /// </summary>
    [IsoId("_TPA3tdp-Ed-ak6NoX_4Aeg_-80545028")]
    [DisplayName("Additional Status Reason Information")]
    [IsoXmlTag("AddtlStsRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalStatusReasonInformation { get; init; }
}
