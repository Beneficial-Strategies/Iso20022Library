// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the creditor.
/// </summary>
[IsoId("_Urs4Itp-Ed-ak6NoX_4Aeg_1405520878")]
[DisplayName("Creditor")]
public partial record Creditor2
{
    #nullable enable
    
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_Urs4I9p-Ed-ak6NoX_4Aeg_1405520880")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification2Choice_? Creditor { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Urs4JNp-Ed-ak6NoX_4Aeg_1405520930")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentificationAndName3 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that is the ultimate beneficiary of the credit transfer. The final party is mentioned when different from the creditor, whose account will be credited by the final agent.
    /// </summary>
    [IsoId("_Urs4Jdp-Ed-ak6NoX_4Aeg_1405520895")]
    [DisplayName("Final Agent")]
    [IsoXmlTag("FnlAgt")]
    public required FinancialInstitutionIdentification3Choice_ FinalAgent { get; init; } 
    
    
    #nullable disable
    
}
