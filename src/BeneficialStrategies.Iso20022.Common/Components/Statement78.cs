// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
[IsoId("_SnKxcMRtEeij-rSPpvD-Tw")]
[DisplayName("Statement")]
public record Statement78
{
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_47krEcRuEeij-rSPpvD-Tw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; }

    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_0GkD9MRuEeij-rSPpvD-Tw")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_22HadMRuEeij-rSPpvD-Tw")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_7YOTtMRuEeij-rSPpvD-Tw")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("__jIN5MRuEeij-rSPpvD-Tw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency22Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_B7nvRMRvEeij-rSPpvD-Tw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; }

    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_dFvXMMRvEeij-rSPpvD-Tw")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public required CollateralRole1Code CollateralSide { get; init; }

    /// <summary>
    /// Specifies the basis on which the statement is prepared.
    /// </summary>
    [IsoId("_vd22oMRyEeij-rSPpvD-Tw")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasis14Choice_ StatementBasis { get; init; }

    /// <summary>
    /// Specifies whether the transactions reported are pending or confirmed.
    /// </summary>
    [IsoId("_F_VYwNBWEeiirviLm7P0IA")]
    [DisplayName("Status Type")]
    [IsoXmlTag("StsTp")]
    public StatementStatusType1Code? StatusType { get; init; }

    /// <summary>
    /// Indicates whether the report is a summary.
    /// If the indicator is set to Y then the report will not contain the securities or cash balances.
    /// If the indicator is set to N then the report will contain the securities or cash balances.
    /// </summary>
    [IsoId("_0-gEFLFBEeqMo4JxiuZGSw")]
    [DisplayName("Summary Indicator")]
    [IsoXmlTag("SummryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SummaryIndicator { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_EmtchMRvEeij-rSPpvD-Tw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
