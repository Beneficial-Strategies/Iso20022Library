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
[IsoId("_5rYVR5EsEeajS_7NioJdVA")]
[DisplayName("Corporate Action Unallocated Details SD")]
public partial record CorporateActionUnallocatedDetailsSD5
{
    #nullable enable
    
    /// <summary>
    /// Type of Participants positions distribution balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_6Eh08ZEsEeajS_7NioJdVA")]
    [DisplayName("Unallocated Distribution Balance")]
    [IsoXmlTag("UallctdDstrbtnBal")]
    public CorporateActionUnallocatedBalanceSD2Choice_? UnallocatedDistributionBalance { get; init; } 
    
    /// <summary>
    /// Type of Participants positions redemption balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_6Eh0-ZEsEeajS_7NioJdVA")]
    [DisplayName("Unallocated Redemption Balance")]
    [IsoXmlTag("UallctdRedBal")]
    public CorporateActionUnallocatedBalanceSD1? UnallocatedRedemptionBalance { get; init; } 
    
    /// <summary>
    /// Type of participants positions reorganisation balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_9elrkJEtEeajS_7NioJdVA")]
    [DisplayName("Unallocated Reorganisation Balance")]
    [IsoXmlTag("UallctdReorgBal")]
    public CorporateActionUnallocatedBalanceSD2? UnallocatedReorganisationBalance { get; init; } 
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_6Eh0-5EsEeajS_7NioJdVA")]
    [DisplayName("Unallocated Securities Transaction Details")]
    [IsoXmlTag("UallctdSctiesTxDtls")]
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD6? UnallocatedSecuritiesTransactionDetails { get; init; } 
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_6Eh1A5EsEeajS_7NioJdVA")]
    [DisplayName("Unallocated Cash Transaction Details")]
    [IsoXmlTag("UallctdCshTxDtls")]
    public CorporateActionUnallocatedCashTransactionDetailsSD5? UnallocatedCashTransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
