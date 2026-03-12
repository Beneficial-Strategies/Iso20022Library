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
[IsoId("_U1-1h9p-Ed-ak6NoX_4Aeg_418582784")]
[DisplayName("Statement")]
public partial record Statement3
{
    #nullable enable
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_U1-1iNp-Ed-ak6NoX_4Aeg_1230355880")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_U2H_cNp-Ed-ak6NoX_4Aeg_1259907394")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Preparation date of the statement.
    /// </summary>
    [IsoId("_U2H_cdp-Ed-ak6NoX_4Aeg_1288539329")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_U2H_ctp-Ed-ak6NoX_4Aeg_2104932020")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public FrequencyCodeAndDSSCodeChoice_? Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_U2H_c9p-Ed-ak6NoX_4Aeg_89869516")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public StatementUpdateTypeCodeAndDSSCodeChoice_? UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    [IsoId("_U2H_dNp-Ed-ak6NoX_4Aeg_878182929")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_U2H_ddp-Ed-ak6NoX_4Aeg_-1498270245")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public StatementBasisCodeAndDSSCodeChoice_? StatementBasis { get; init; } 
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_U2H_dtp-Ed-ak6NoX_4Aeg_-1548136909")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; } 
    
    
    #nullable disable
    
}
