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
[IsoId("_xeRfEQzJEeuTPv2wqaotHg")]
[DisplayName("Statement")]
public partial record Statement83
{
    #nullable enable
    
    /// <summary>
    /// Date or period of the statement.
    /// </summary>
    [IsoId("_xstjtQzJEeuTPv2wqaotHg")]
    [DisplayName("Statement Date Or Period")]
    [IsoXmlTag("StmtDtOrPrd")]
    public DateAndPeriod3Choice_? StatementDateOrPeriod { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_xstjvQzJEeuTPv2wqaotHg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_xstjxQzJEeuTPv2wqaotHg")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType15Choice_? UpdateType { get; init; } 
    
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_xstjzQzJEeuTPv2wqaotHg")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public StatementBasis7Choice_? StatementBasis { get; init; } 
    
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_xstj1QzJEeuTPv2wqaotHg")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public StatementType5Choice_? StatementType { get; init; } 
    
    
    #nullable disable
    
}
