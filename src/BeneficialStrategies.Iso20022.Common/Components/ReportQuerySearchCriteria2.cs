// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a report.
/// </summary>
[IsoId("_3b6DFZb6Eee4htziCyV8eA")]
[DisplayName("Report Query Search Criteria")]
public record ReportQuerySearchCriteria2
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_3pS-0Zb6Eee4htziCyV8eA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> AccountIdentification { get; init; } =
        [];

    /// <summary>
    /// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
    /// </summary>
    [IsoId("_3pS-05b6Eee4htziCyV8eA")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance12> Balance { get; init; } = [];

    /// <summary>
    /// Values of possible reports.
    /// </summary>
    [IsoId("_3pS-1Zb6Eee4htziCyV8eA")]
    [DisplayName("Report Name")]
    [IsoXmlTag("RptNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4AlphaNumericText? ReportName { get; init; }

    /// <summary>
    /// Specifies the query message name identifier to which the message refers.
    /// </summary>
    [IsoId("_S1RJ0Fg7Eeiv7OYKCzUSAg")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; }

    /// <summary>
    /// Report owning party.
    /// </summary>
    [IsoId("_3pS-15b6Eee4htziCyV8eA")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification136 PartyIdentification { get; init; }

    /// <summary>
    /// Responsible Party of the report owning party.
    /// </summary>
    [IsoId("_3pS-2Zb6Eee4htziCyV8eA")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; }

    /// <summary>
    /// Date and time when the report was created.
    /// </summary>
    [IsoId("_3pS-25b6Eee4htziCyV8eA")]
    [DisplayName("Date Search")]
    [IsoXmlTag("DtSch")]
    public DatePeriodSearch1Choice_? DateSearch { get; init; }

    /// <summary>
    /// Time when the (business) event, which triggered the report, was scheduled.
    /// </summary>
    [IsoId("_3pS-3Zb6Eee4htziCyV8eA")]
    [DisplayName("Scheduled Time")]
    [IsoXmlTag("SchdldTm")]
    public DateTimePeriod1Choice_? ScheduledTime { get; init; }

    /// <summary>
    /// Execution type is executed based on an event driven trigger.
    /// </summary>
    [IsoId("_mEwyoVg9Eeiv7OYKCzUSAg")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public EventType1Choice_? Event { get; init; }
}
