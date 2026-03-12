// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a bank account
/// </summary>
[IsoId("_U2KG0brQEeiRnc958wUXqA")]
[DisplayName("Account Details")]
public partial record AccountDetails2
{
    #nullable enable
    
    /// <summary>
    /// Name of the account as assigned by the account servicing institution in an agreement with the account owner in order to provide an additional means of identification of the account.
    /// </summary>
    [IsoId("_VAbdJbrQEeiRnc958wUXqA")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; } 
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// See ISO 8583 bit 3, Account type codes
    /// </summary>
    [IsoId("_5cOr0LrQEeiRnc958wUXqA")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public IsoExact2AlphaNumericText? AccountType { get; init; } 
    
    /// <summary>
    /// Identification of an account.
    /// ISO 8583 bit 102 or bit 103
    /// </summary>
    [IsoId("_j-EPMbrSEeiRnc958wUXqA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
