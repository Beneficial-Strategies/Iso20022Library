// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
[IsoId("_AX6mMNokEeC60axPepSq7g_-1810191064")]
[DisplayName("Report")]
public record Report3
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_AX6mMdokEeC60axPepSq7g_-1035821271")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Gives the name and the reference of the query.
    /// </summary>
    [IsoId("_AX6mMtokEeC60axPepSq7g_-1992012618")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public QueryReference? QueryReference { get; init; }

    /// <summary>
    /// Reference of the report.
    /// </summary>
    [IsoId("_AX6mM9okEeC60axPepSq7g_-2032893624")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReportIdentification { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_AX6mNNokEeC60axPepSq7g_1378840385")]
    [DisplayName("Report Date Time")]
    [IsoXmlTag("RptDtTm")]
    public required DateAndDateTime1Choice_ ReportDateTime { get; init; }

    /// <summary>
    /// Specifies the regularity of an event.
    /// </summary>
    [IsoId("_AX6mNdokEeC60axPepSq7g_1638546903")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency4Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_AYEXMNokEeC60axPepSq7g_75090148")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public StatementUpdateTypeCodeAndDSSCodeChoice_? UpdateType { get; init; }

    /// <summary>
    /// Notifies the type of report transmitted.
    /// </summary>
    [IsoId("_AYEXMdokEeC60axPepSq7g_-912509466")]
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public GenericIdentification38? NoticeType { get; init; }
}
