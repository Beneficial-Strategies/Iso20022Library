// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to fully identify the type of the bank transaction entry.
/// </summary>
[IsoId("_TVHfuNp-Ed-ak6NoX_4Aeg_-2139976485")]
[DisplayName("Bank Transaction Code Structure")]
public partial record BankTransactionCodeStructure1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the domain, the family and the sub-family of the bank transaction code, in a structured and hierarchical format.||Usage: If a specific family or subfamily code cannot be provided, the generic family code defined for the domain or the generic subfamily code defined for the family should be provided.
    /// </summary>
    [IsoId("_TVHfudp-Ed-ak6NoX_4Aeg_808584240")]
    [DisplayName("Domain")]
    [IsoXmlTag("Domn")]
    public BankTransactionCodeStructure2? Domain { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the bank transaction code, as defined by the issuer.
    /// </summary>
    [IsoId("_TVHfutp-Ed-ak6NoX_4Aeg_-1913772033")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryBankTransactionCodeStructure1? Proprietary { get; init; } 
    
    
    #nullable disable
    
}
