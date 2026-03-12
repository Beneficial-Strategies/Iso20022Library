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
[IsoId("_B51cYUNTEeiut6dbx3wnBg")]
[DisplayName("Account Balance")]
public partial record AccountBalance1
{
    #nullable enable
    
    /// <summary>
    /// Account for which a balance is sought.
    /// See ISO 8583 bit 54, Account type codes
    /// </summary>
    [IsoId("_CFvKYUNTEeiut6dbx3wnBg")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText AccountType { get; init; } 
    
    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_CFvKY0NTEeiut6dbx3wnBg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public Balance15? Balance { get; init; } 
    
    
    #nullable disable
    
}
