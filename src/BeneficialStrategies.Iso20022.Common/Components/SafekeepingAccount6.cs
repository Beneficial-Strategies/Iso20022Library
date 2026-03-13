// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// A safekeeping account is an account on which a securities entry is made.
/// </summary>
[IsoId("_HjiCdVtiEeSwKe7KuKvXhg")]
[DisplayName("Safekeeping Account")]
public partial record SafekeepingAccount6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_IAPzl1tiEeSwKe7KuKvXhg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_IAPzmVtiEeSwKe7KuKvXhg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification40Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_IAPzm1tiEeSwKe7KuKvXhg")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount2? SubAccountDetails { get; init; } 
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_IAPznVtiEeSwKe7KuKvXhg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<HoldingBalance8> InstructedBalance { get; init; } = [];
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_IAPzn1tiEeSwKe7KuKvXhg")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification40Choice_> RightsHolder { get; init; } = [];
    
    
    #nullable disable
    
}
