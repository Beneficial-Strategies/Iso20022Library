// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for a payment transaction.
/// </summary>
[IsoId("_-9kb2wKxEe2rHs6fbn9-0A")]
[DisplayName("Transaction Search Criteria")]
public partial record TransactionSearchCriteria10
{
    #nullable enable
    
    /// <summary>
    /// Defines the criteria which are used to search for the destination of the payment.
    /// </summary>
    [IsoId("__oKQ8QKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public SystemSearch4? PaymentTo { get; init; } 
    
    /// <summary>
    /// Defines the criteria which are used to search for the origin of the payment.
    /// </summary>
    [IsoId("__oKQ8wKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public SystemSearch4? PaymentFrom { get; init; } 
    
    /// <summary>
    /// Defines the criteria which are used to search for a payment.
    /// </summary>
    [IsoId("__oKQ9QKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment Search")]
    [IsoXmlTag("PmtSch")]
    public PaymentSearch9? PaymentSearch { get; init; } 
    
    /// <summary>
    /// Defines the criteria which are used to search for a cash entry.
    /// </summary>
    [IsoId("__oKQ9wKxEe2rHs6fbn9-0A")]
    [DisplayName("Account Entry Search")]
    [IsoXmlTag("AcctNtrySch")]
    public CashAccountEntrySearch7? AccountEntrySearch { get; init; } 
    
    
    #nullable disable
    
}
