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
[IsoId("_RFBsYNp-Ed-ak6NoX_4Aeg_389014624")]
[DisplayName("Pagination Balance")]
public partial record PaginationBalance1
{
    #nullable enable
    
    /// <summary>
    /// Opening balance of the financial instrument in the statement.
    /// </summary>
    [IsoId("_RFBsYdp-Ed-ak6NoX_4Aeg_777817466")]
    [DisplayName("First Opening Balance")]
    [IsoXmlTag("FrstOpngBal")]
    public FinancialInstrumentQuantity1? FirstOpeningBalance { get; init; } 
    
    /// <summary>
    /// Opening balance of this page only. It must be the interemdiary closing balance of the previous page (part of the same statement).
    /// </summary>
    [IsoId("_RFBsYtp-Ed-ak6NoX_4Aeg_777817508")]
    [DisplayName("Intermediary Opening Balance")]
    [IsoXmlTag("IntrmyOpngBal")]
    public FinancialInstrumentQuantity1? IntermediaryOpeningBalance { get; init; } 
    
    /// <summary>
    /// Closing balance of the financial instrument in the statement.
    /// </summary>
    [IsoId("_RFBsY9p-Ed-ak6NoX_4Aeg_777817561")]
    [DisplayName("Final Closing Balance")]
    [IsoXmlTag("FnlClsgBal")]
    public FinancialInstrumentQuantity1? FinalClosingBalance { get; init; } 
    
    /// <summary>
    /// Closing Balance of this page only. Must be the interemdiary opening balance of the next page (part of the same statement).
    /// </summary>
    [IsoId("_RFBsZNp-Ed-ak6NoX_4Aeg_777817933")]
    [DisplayName("Intermediary Closing Balance")]
    [IsoXmlTag("IntrmyClsgBal")]
    public FinancialInstrumentQuantity1? IntermediaryClosingBalance { get; init; } 
    
    
    #nullable disable
    
}
