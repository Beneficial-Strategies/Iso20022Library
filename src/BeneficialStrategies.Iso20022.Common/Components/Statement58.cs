// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the report.
/// </summary>
[IsoId("_a-uBse0kEeWGZ8O9Moj6Zw")]
[DisplayName("Statement58")]
public record Statement58
{
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_bIFZE-0kEeWGZ8O9Moj6Zw")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a report.
    /// </summary>
    [IsoId("_bIFZG-0kEeWGZ8O9Moj6Zw")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax35Text? ReportIdentification { get; init; }

    /// <summary>
    /// Specifies whether the data is either historical (true) or current (false).
    /// </summary>
    [IsoId("_bIFZHe0kEeWGZ8O9Moj6Zw")]
    [DisplayName("Historic Data")]
    [IsoXmlTag("HstrcData")]
    public required IsoTrueFalseIndicator HistoricData { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_bIFZJe0kEeWGZ8O9Moj6Zw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_bIFZLe0kEeWGZ8O9Moj6Zw")]
    [DisplayName("Sub Account Indicator")]
    [IsoXmlTag("SubAcctInd")]
    public required IsoYesNoIndicator SubAccountIndicator { get; init; }
}
