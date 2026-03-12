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
[IsoId("_l2NFwWJTEeOfOt7Y7nAPUA")]
[DisplayName("Corporate Action Unallocated Details SD")]
public partial record CorporateActionUnallocatedDetailsSD2
{
    #nullable enable
    
    /// <summary>
    /// Type of Participants positions balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_mPo5f2JTEeOfOt7Y7nAPUA")]
    [DisplayName("Unallocated Balance")]
    [IsoXmlTag("UallctdBal")]
    public CorporateActionUnallocatedBalanceSD1Choice_? UnallocatedBalance { get; init; } 
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_mPo5h2JTEeOfOt7Y7nAPUA")]
    [DisplayName("Unallocated Securities Transaction Details")]
    [IsoXmlTag("UallctdSctiesTxDtls")]
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD2? UnallocatedSecuritiesTransactionDetails { get; init; } 
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_mPo5j2JTEeOfOt7Y7nAPUA")]
    [DisplayName("Unallocated Cash Transaction Details")]
    [IsoXmlTag("UallctdCshTxDtls")]
    public CorporateActionUnallocatedCashTransactionDetailsSD2? UnallocatedCashTransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
