// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to an account.
/// </summary>
[IsoId("_MO4CgQxrEeqdx6buGpCCQw")]
[DisplayName("Payment Account")]
public partial record PaymentAccount3
{
    #nullable enable
    
    /// <summary>
    /// Currency of a Payment Account.
    /// </summary>
    [IsoId("_MZk2oQxrEeqdx6buGpCCQw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Balance of a Payment Account
    /// </summary>
    [IsoId("_MZk2owxrEeqdx6buGpCCQw")]
    [DisplayName("Current Balance")]
    [IsoXmlTag("CurBal")]
    public ImpliedCurrencyAndAmount? CurrentBalance { get; init; } 
    
    /// <summary>
    /// Detail of Acquirer.
    /// </summary>
    [IsoId("_MZk2pQxrEeqdx6buGpCCQw")]
    [DisplayName("Payment Acquirer Data")]
    [IsoXmlTag("PmtAcqrrData")]
    public Acquirer10? PaymentAcquirerData { get; init; } 
    
    
    #nullable disable
    
}
