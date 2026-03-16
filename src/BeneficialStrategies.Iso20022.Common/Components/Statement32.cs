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
[IsoId("_QkZEgNp-Ed-ak6NoX_4Aeg_-430319811")]
[DisplayName("Statement")]
public record Statement32
{
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_QkZEgdp-Ed-ak6NoX_4Aeg_873526407")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QkZEgtp-Ed-ak6NoX_4Aeg_2081190677")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QkZEg9p-Ed-ak6NoX_4Aeg_1504065073")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency1Code Frequency { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_Qki1gNp-Ed-ak6NoX_4Aeg_-1879859122")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }
}
