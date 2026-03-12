// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides header details on the report.
/// </summary>
[IsoId("_IXU44Xk4Eei6JsZKrqN0hQ")]
[DisplayName("Report Header")]
public partial record ReportHeader6
{
    #nullable enable
    
    /// <summary>
    /// Identification of a report billing statement.
    /// </summary>
    [IsoId("_IijRc3k4Eei6JsZKrqN0hQ")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReportIdentification { get; init; } 
    
    /// <summary>
    /// Provides details on the page number of the message.
    /// Usage: The pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_IijRdXk4Eei6JsZKrqN0hQ")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; } 
    
    
    #nullable disable
    
}
