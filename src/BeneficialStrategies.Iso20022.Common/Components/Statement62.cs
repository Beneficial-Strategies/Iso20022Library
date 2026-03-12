// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
[IsoId("_nocSUbPuEeelzbgsFa3sqQ")]
[DisplayName("Statement")]
public partial record Statement62
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the portfolio transfer counterpart to unambiguously identify a portfolio transfer notification.
    /// </summary>
    [IsoId("_n5GkgbPuEeelzbgsFa3sqQ")]
    [DisplayName("Counterparty Portfolio Transfer Notification Reference")]
    [IsoXmlTag("CtrPtyPrtflTrfNtfctnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CounterpartyPortfolioTransferNotificationReference { get; init; } 
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_n5Gkg7PuEeelzbgsFa3sqQ")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; } 
    
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_n5Gki7PuEeelzbgsFa3sqQ")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; } 
    
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_n5GkjbPuEeelzbgsFa3sqQ")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_n5GklbPuEeelzbgsFa3sqQ")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType15Choice_? UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_n5GknbPuEeelzbgsFa3sqQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
