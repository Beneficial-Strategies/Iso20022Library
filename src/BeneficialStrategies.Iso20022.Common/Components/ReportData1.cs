// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numerical representation of the net increases and decreases in an account at a specific point in time.
/// </summary>
[IsoId("_SXbvdtp-Ed-ak6NoX_4Aeg_-759204181")]
[DisplayName("Report Data1")]
[Obsolete]
public record ReportData1
{
    /// <summary>
    /// Identification of the report assigned by the central system.
    /// </summary>
    [IsoId("_SXbvd9p-Ed-ak6NoX_4Aeg_-759204120")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date by which the amount(s) requested must be settled.
    /// </summary>
    [IsoId("_SXk5YNp-Ed-ak6NoX_4Aeg_628613877")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Date and time on which the report is generated.
    /// </summary>
    [IsoId("_SXk5Ydp-Ed-ak6NoX_4Aeg_-759204151")]
    [DisplayName("Date And Time Stamp")]
    [IsoXmlTag("DtAndTmStmp")]
    public required IsoISODateTime DateAndTimeStamp { get; init; }

    /// <summary>
    /// Specifies the type of the Pay In Call.
    /// </summary>
    [IsoId("_SXk5Ytp-Ed-ak6NoX_4Aeg_-759204059")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CallIn1Code Type { get; init; }

    /// <summary>
    /// Specifies the amount requested.
    /// </summary>
    [IsoId("_SXk5Y9p-Ed-ak6NoX_4Aeg_1451930490")]
    [DisplayName("Pay In Call Amount")]
    [IsoXmlTag("PayInCallAmt")]
    public ValueList<PayInCallItem> PayInCallAmount { get; init; } = [];

    /// <summary>
    /// Specifies the requested amount in multiple currencies.
    /// </summary>
    [IsoId("_SXk5ZNp-Ed-ak6NoX_4Aeg_-2100983347")]
    [DisplayName("Alternate Value")]
    [IsoXmlTag("AltrnVal")]
    public Value? AlternateValue { get; init; }
}
