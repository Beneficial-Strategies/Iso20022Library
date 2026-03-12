// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the corporate action event.
/// </summary>
[IsoId("_FHN1IaIoEeS6IulNYwkZBg")]
[DisplayName("Corporate Action Unallocated Details SD")]
public partial record CorporateActionUnallocatedDetailsSD3
{
    #nullable enable
    
    /// <summary>
    /// Type of Participants positions distribution balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_FRMQgaIoEeS6IulNYwkZBg")]
    [DisplayName("Unallocated Distribution Balance")]
    [IsoXmlTag("UallctdDstrbtnBal")]
    public CorporateActionUnallocatedBalanceSD2Choice_? UnallocatedDistributionBalance { get; init; } 
    
    /// <summary>
    /// Type of Participants positions redemption balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_7oZOoKJFEeS6IulNYwkZBg")]
    [DisplayName("Unallocated Redemption Balance")]
    [IsoXmlTag("UallctdRedBal")]
    public CorporateActionUnallocatedBalanceSD1? UnallocatedRedemptionBalance { get; init; } 
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_FRMQiaIoEeS6IulNYwkZBg")]
    [DisplayName("Unallocated Securities Transaction Details")]
    [IsoXmlTag("UallctdSctiesTxDtls")]
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD4? UnallocatedSecuritiesTransactionDetails { get; init; } 
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_FRMQkaIoEeS6IulNYwkZBg")]
    [DisplayName("Unallocated Cash Transaction Details")]
    [IsoXmlTag("UallctdCshTxDtls")]
    public CorporateActionUnallocatedCashTransactionDetailsSD3? UnallocatedCashTransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
