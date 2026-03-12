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
[IsoId("_tk03Lw-rEeuE0Pnt-OcNOA")]
[DisplayName("Corporate Action Unallocated Details SD")]
public partial record CorporateActionUnallocatedDetailsSD7
{
    #nullable enable
    
    /// <summary>
    /// Type of Participants positions distribution balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_t5zBYQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Unallocated Distribution Balance")]
    [IsoXmlTag("UallctdDstrbtnBal")]
    public CorporateActionUnallocatedBalanceSD3Choice_? UnallocatedDistributionBalance { get; init; } 
    
    /// <summary>
    /// Type of Participants positions redemption balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_t5zBaQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Unallocated Redemption Balance")]
    [IsoXmlTag("UallctdRedBal")]
    public CorporateActionUnallocatedBalanceSD3? UnallocatedRedemptionBalance { get; init; } 
    
    /// <summary>
    /// Type of participants positions reorganisation balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_t5zBaw-rEeuE0Pnt-OcNOA")]
    [DisplayName("Unallocated Reorganisation Balance")]
    [IsoXmlTag("UallctdReorgBal")]
    public CorporateActionUnallocatedBalanceSD4? UnallocatedReorganisationBalance { get; init; } 
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_t5zBbQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Unallocated Securities Transaction Details")]
    [IsoXmlTag("UallctdSctiesTxDtls")]
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD8? UnallocatedSecuritiesTransactionDetails { get; init; } 
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_t5zBdQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Unallocated Cash Transaction Details")]
    [IsoXmlTag("UallctdCshTxDtls")]
    public CorporateActionUnallocatedCashTransactionDetailsSD7? UnallocatedCashTransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
