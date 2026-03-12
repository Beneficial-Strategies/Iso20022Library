// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
[IsoId("_Rhyg4Np-Ed-ak6NoX_4Aeg_2060760471")]
[DisplayName("Statement")]
public partial record Statement10
{
    #nullable enable
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_Rhyg4dp-Ed-ak6NoX_4Aeg_2060760502")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identifier { get; init; } 
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_Rhyg4tp-Ed-ak6NoX_4Aeg_2060760533")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_Rhyg49p-Ed-ak6NoX_4Aeg_2060760648")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required FrequencyCodeAndDSSCode1Choice_ Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_Rhyg5Np-Ed-ak6NoX_4Aeg_2060760679")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_Rhyg5dp-Ed-ak6NoX_4Aeg_2060760957")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_Rhyg5tp-Ed-ak6NoX_4Aeg_2060760988")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; init; } 
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_Rhyg59p-Ed-ak6NoX_4Aeg_2060761018")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; } 
    
    
    #nullable disable
    
}
