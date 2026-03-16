// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Query Search Criteria3.
/// </summary>
[IsoId("_6fCc1TEyEe6g-ffJsqGiSA")]
[DisplayName("Report Query Search Criteria3")]
public partial record ReportQuerySearchCriteria3
{
    #nullable enable

    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> AccountIdentification { get; init; } = [];

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance14> Balance { get; init; } = [];

    /// <summary>
    /// Date Search.
    /// </summary>
    [DisplayName("Date Search")]
    [IsoXmlTag("DtSch")]
    public DatePeriodSearch1Choice_? DateSearch { get; init; } 

    /// <summary>
    /// Event.
    /// </summary>
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public EventType1Choice_? Event { get; init; } 

    /// <summary>
    /// Message Name Identification.
    /// </summary>
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    public IsoMax35Text? MessageNameIdentification { get; init; } 

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification136 PartyIdentification { get; init; } 

    /// <summary>
    /// Report Name.
    /// </summary>
    [DisplayName("Report Name")]
    [IsoXmlTag("RptNm")]
    public IsoMax4AlphaNumericText? ReportName { get; init; } 

    /// <summary>
    /// Responsible Party Identification.
    /// </summary>
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 

    /// <summary>
    /// Scheduled Time.
    /// </summary>
    [DisplayName("Scheduled Time")]
    [IsoXmlTag("SchdldTm")]
    public DateTimePeriod1Choice_? ScheduledTime { get; init; } 

    
    #nullable disable
    
}
