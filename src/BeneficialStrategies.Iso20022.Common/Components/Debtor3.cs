// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the debtor.
/// </summary>
[IsoId("_2qFr0dpqEeearpaEPXv9UA")]
[DisplayName("Debtor")]
public partial record Debtor3
{
    #nullable enable
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    [IsoId("_2y0KAdpqEeearpaEPXv9UA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification100Choice_? Debtor { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_2y0KA9pqEeearpaEPXv9UA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public CashAccountIdentification7Choice_? AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
