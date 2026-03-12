// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the beneficiary&apos;s account information for the settlement of a purchase of goods or services.
/// </summary>
[IsoId("_w3wF8RVXEeOCqpkCrPgk4g")]
[DisplayName("Settlement Terms")]
public partial record SettlementTerms3
{
    #nullable enable
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, and posts the transaction into the account.
    /// </summary>
    [IsoId("_xSIU0RVXEeOCqpkCrPgk4g")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public FinancialInstitutionIdentification4Choice_? CreditorAgent { get; init; } 
    
    /// <summary>
    /// Account to be credited as a result of an instruction.
    /// </summary>
    [IsoId("_xSIU0xVXEeOCqpkCrPgk4g")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount24 CreditorAccount { get; init; } 
    
    
    #nullable disable
    
}
