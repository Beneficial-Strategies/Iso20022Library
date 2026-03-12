// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the charges related to the payment transaction.
/// </summary>
[IsoId("_RtHAHtp-Ed-ak6NoX_4Aeg_-171353542")]
[DisplayName("Charges Information")]
public partial record ChargesInformation7
{
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_RtHAH9p-Ed-ak6NoX_4Aeg_-117292823")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Party that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_RtHAINp-Ed-ak6NoX_4Aeg_911025084")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required BranchAndFinancialInstitutionIdentification5 Party { get; init; } 
    
    
    #nullable disable
    
}
