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
[IsoId("_1YlrQDL3EeKU9IrkkToqcw_1723135962")]
[DisplayName("Corporate Action Unallocated Details SD")]
public partial record CorporateActionUnallocatedDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_1YlrQTL3EeKU9IrkkToqcw_-434487002")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Type of Participants positions balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_1YlrQjL3EeKU9IrkkToqcw_1011922619")]
    [DisplayName("Unallocated Balance")]
    [IsoXmlTag("UallctdBal")]
    public CorporateActionUnallocatedBalanceSD1Choice_? UnallocatedBalance { get; init; } 
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_1YlrQzL3EeKU9IrkkToqcw_-1811501059")]
    [DisplayName("Unallocated Securities Transaction Details")]
    [IsoXmlTag("UallctdSctiesTxDtls")]
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD1? UnallocatedSecuritiesTransactionDetails { get; init; } 
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_1YlrRDL3EeKU9IrkkToqcw_883092187")]
    [DisplayName("Unallocated Cash Transaction Details")]
    [IsoXmlTag("UallctdCshTxDtls")]
    public CorporateActionUnallocatedCashTransactionDetailsSD1? UnallocatedCashTransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
