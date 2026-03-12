// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
[IsoId("_1dwnkIq7EeSHjtO_wHA7PQ")]
[DisplayName("ATM Account Statement")]
public partial record ATMAccountStatement1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_DT20sIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public required AccountIdentification31Choice_ AccountIdentifier { get; init; } 
    
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_LL9ZYIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; } 
    
    /// <summary>
    /// Statement information.
    /// </summary>
    [IsoId("_XaRwYIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Account Statement")]
    [IsoXmlTag("AcctStmt")]
    public ATMAccountStatement2? AccountStatement { get; init; } 
    
    
    #nullable disable
    
}
