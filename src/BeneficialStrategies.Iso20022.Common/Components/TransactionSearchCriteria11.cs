// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Search Criteria11.
/// </summary>
[IsoId("_3NIAKzEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction Search Criteria11")]
public partial record TransactionSearchCriteria11
{
    #nullable enable

    /// <summary>
    /// Account Entry Search.
    /// </summary>
    [DisplayName("Account Entry Search")]
    [IsoXmlTag("AcctNtrySch")]
    public CashAccountEntrySearch8? AccountEntrySearch { get; init; } 

    /// <summary>
    /// Payment From.
    /// </summary>
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public ValueList<SystemSearch5> PaymentFrom { get; init; } = [];

    /// <summary>
    /// Payment Search.
    /// </summary>
    [DisplayName("Payment Search")]
    [IsoXmlTag("PmtSch")]
    public PaymentSearch10? PaymentSearch { get; init; } 

    /// <summary>
    /// Payment To.
    /// </summary>
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public ValueList<SystemSearch5> PaymentTo { get; init; } = [];

    
    #nullable disable
    
}
