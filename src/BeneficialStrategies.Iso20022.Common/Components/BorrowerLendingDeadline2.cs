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
[IsoId("_U-_Ck5nPEeWLs7cvLxlyAg")]
[DisplayName("Borrower Lending Deadline")]
public partial record BorrowerLendingDeadline2
{
    #nullable enable
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_U-_ClZnPEeWLs7cvLxlyAg")]
    [DisplayName("Stock Lending Deadline")]
    [IsoXmlTag("StockLndgDdln")]
    public required DateFormat34Choice_ StockLendingDeadline { get; init; } 
    
    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    [IsoId("_U-_ClJnPEeWLs7cvLxlyAg")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public required PartyIdentification103Choice_ Borrower { get; init; } 
    
    
    #nullable disable
    
}
