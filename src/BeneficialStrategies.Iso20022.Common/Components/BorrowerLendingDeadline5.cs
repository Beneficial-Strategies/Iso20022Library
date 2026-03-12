// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stock lending deadline assigned to a borrower of the stock.
/// </summary>
[IsoId("_a5bfp7XDEeiTob_PrFFUxA")]
[DisplayName("Borrower Lending Deadline")]
public partial record BorrowerLendingDeadline5
{
    #nullable enable
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_bK1YcbXDEeiTob_PrFFUxA")]
    [DisplayName("Stock Lending Deadline")]
    [IsoXmlTag("StockLndgDdln")]
    public required DateFormat43Choice_ StockLendingDeadline { get; init; } 
    
    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    [IsoId("_bK1Yc7XDEeiTob_PrFFUxA")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public required PartyIdentification127Choice_ Borrower { get; init; } 
    
    
    #nullable disable
    
}
