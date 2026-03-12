// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance of the account involved in the card transaction.
/// </summary>
[IsoId("_K3LGsaycEeupy7O5H7ITjQ")]
[DisplayName("Account Balance")]
public partial record AccountBalance2
{
    #nullable enable
    
    /// <summary>
    /// Account for which a balance is sought.
    /// This code list is maintained by the ISO 8583/MA (maintenance agency).
    /// </summary>
    [IsoId("_K7YRQaycEeupy7O5H7ITjQ")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public required ISO8583AccountTypeCode AccountType { get; init; } 
    
    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_K7YRQ6ycEeupy7O5H7ITjQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public Balance28? Balance { get; init; } 
    
    
    #nullable disable
    
}
