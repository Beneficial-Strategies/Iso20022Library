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
[IsoId("_R3C1V52IEeW-bsa36JFb9A")]
[DisplayName("Corporate Action Unallocated Details SD")]
public partial record CorporateActionUnallocatedDetailsSD4
{
    #nullable enable
    
    /// <summary>
    /// Type of Participants positions distribution balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzvYZ2IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Distribution Balance")]
    [IsoXmlTag("UallctdDstrbtnBal")]
    public CorporateActionUnallocatedBalanceSD2Choice_? UnallocatedDistributionBalance { get; init; } 
    
    /// <summary>
    /// Type of Participants positions redemption balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzvaZ2IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Redemption Balance")]
    [IsoXmlTag("UallctdRedBal")]
    public CorporateActionUnallocatedBalanceSD1? UnallocatedRedemptionBalance { get; init; } 
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzva52IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Securities Transaction Details")]
    [IsoXmlTag("UallctdSctiesTxDtls")]
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD5? UnallocatedSecuritiesTransactionDetails { get; init; } 
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzvc52IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Cash Transaction Details")]
    [IsoXmlTag("UallctdCshTxDtls")]
    public CorporateActionUnallocatedCashTransactionDetailsSD4? UnallocatedCashTransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
