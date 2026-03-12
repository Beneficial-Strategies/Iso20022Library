// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Code of the underlying bank transaction.
/// </summary>
[IsoId("_TVHftdp-Ed-ak6NoX_4Aeg_749476994")]
[DisplayName("Bank Transaction Code Structure")]
public partial record BankTransactionCodeStructure2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the business area of the underlying transaction.
    /// </summary>
    [IsoId("_TVHfttp-Ed-ak6NoX_4Aeg_749477114")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ExternalBankTransactionDomainCode Code { get; init; } 
    
    /// <summary>
    /// Specifies the family and the sub-family of the bank transaction code, within a specific domain, in a structured and hierarchical format.
    /// </summary>
    [IsoId("_TVHft9p-Ed-ak6NoX_4Aeg_-989327573")]
    [DisplayName("Family")]
    [IsoXmlTag("Fmly")]
    public required BankTransactionCodeStructure3 Family { get; init; } 
    
    
    #nullable disable
    
}
