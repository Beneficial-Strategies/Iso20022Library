// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides statement details such as the account owner identification (ie, the clearing member identification) and optionaly the non clearing member identification, the clearing account or the list of trade legs.
/// </summary>
[IsoId("_QllXWNp-Ed-ak6NoX_4Aeg_530575505")]
[DisplayName("Statement")]
public partial record Statement31
{
    #nullable enable
    
    /// <summary>
    /// Identification that is common to all pages of a statement.
    /// </summary>
    [IsoId("_QlvIUNp-Ed-ak6NoX_4Aeg_-743464227")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; } 
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_QlvIUdp-Ed-ak6NoX_4Aeg_1952721885")]
    [DisplayName("Statement Date And Time")]
    [IsoXmlTag("StmtDtAndTm")]
    public required DateAndDateTimeChoice_ StatementDateAndTime { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QlvIUtp-Ed-ak6NoX_4Aeg_-1456594796")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateType1Code UpdateType { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QlvIU9p-Ed-ak6NoX_4Aeg_1407832177")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency6Code Frequency { get; init; } 
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_QlvIVNp-Ed-ak6NoX_4Aeg_2070796472")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
    public IsoExact5NumericText? ReportNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QlvIVdp-Ed-ak6NoX_4Aeg_929830275")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
