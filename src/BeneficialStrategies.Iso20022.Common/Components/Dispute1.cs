// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the dispute details.
/// </summary>
[IsoId("_Ulb4Ftp-Ed-ak6NoX_4Aeg_1250324083")]
[DisplayName("Dispute")]
public record Dispute1
{
    /// <summary>
    /// Unique identification for the margin call request.
    /// </summary>
    [IsoId("_Ulb4F9p-Ed-ak6NoX_4Aeg_-1356799575")]
    [DisplayName("Margin Call Request Identification")]
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MarginCallRequestIdentification { get; init; }

    /// <summary>
    /// Disputed amount.
    /// </summary>
    [IsoId("_Ulb4GNp-Ed-ak6NoX_4Aeg_-1519744300")]
    [DisplayName("Disputed Amount")]
    [IsoXmlTag("DsptdAmt")]
    public required ActiveCurrencyAndAmount DisputedAmount { get; init; }

    /// <summary>
    /// Date of dispute.
    /// </summary>
    [IsoId("_UllpENp-Ed-ak6NoX_4Aeg_686253594")]
    [DisplayName("Dispute Date")]
    [IsoXmlTag("DsptDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DisputeDate { get; init; }
}
