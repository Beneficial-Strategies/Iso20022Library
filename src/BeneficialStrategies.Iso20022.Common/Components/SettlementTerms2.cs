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
[IsoId("_QIrY5tp-Ed-ak6NoX_4Aeg_739233613")]
[DisplayName("Settlement Terms")]
public partial record SettlementTerms2
{
    #nullable enable
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, and posts the transaction into the account.
    /// </summary>
    [IsoId("_QIrY59p-Ed-ak6NoX_4Aeg_739233984")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public FinancialInstitutionIdentification4Choice_? CreditorAgent { get; init; } 
    
    /// <summary>
    /// Account to be credited as a result of an instruction.
    /// </summary>
    [IsoId("_QIrY6Np-Ed-ak6NoX_4Aeg_739233923")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount7 CreditorAccount { get; init; } 
    
    
    #nullable disable
    
}
