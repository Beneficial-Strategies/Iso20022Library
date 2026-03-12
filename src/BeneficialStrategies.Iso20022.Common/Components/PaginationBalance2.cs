// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance of a financial instrument for a specific statement page.
/// </summary>
[IsoId("_s56c4QgGEeSxsfb1OEDVsw")]
[DisplayName("Pagination Balance")]
public partial record PaginationBalance2
{
    #nullable enable
    
    /// <summary>
    /// Opening balance of the financial instrument in the statement or of the intermediary opening balance of the page of the statement.
    /// </summary>
    [IsoId("_1WSMQAgGEeSxsfb1OEDVsw")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance3Choice_? OpeningBalance { get; init; } 
    
    /// <summary>
    /// Closing balance of the financial instrument in the statement or of the intermediary closing balance of the page of the statement.
    /// </summary>
    [IsoId("_ehLAQAgHEeSxsfb1OEDVsw")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance3Choice_? ClosingBalance { get; init; } 
    
    
    #nullable disable
    
}
