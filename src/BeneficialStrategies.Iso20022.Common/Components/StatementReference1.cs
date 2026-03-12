// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the reference of the statment by a unique identifier and the date (and time).
/// </summary>
[IsoId("_VFEXo04jEeSGlfauTkCKIA")]
[DisplayName("Statement Reference")]
public partial record StatementReference1
{
    #nullable enable
    
    /// <summary>
    /// Reference common to all pages of the statement for which the status advice is sent.
    /// </summary>
    [IsoId("_o3lf4k4jEeSGlfauTkCKIA")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; } 
    
    /// <summary>
    /// Date and time the statement was created.
    /// </summary>
    [IsoId("_o3lf404jEeSGlfauTkCKIA")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Page number of the related message (within the statement) and continuation indicator to indicate that the statement is to continue or that the related message is the last page of the statement.
    /// </summary>
    [IsoId("_B1fu8U4kEeSGlfauTkCKIA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination? Pagination { get; init; } 
    
    
    #nullable disable
    
}
