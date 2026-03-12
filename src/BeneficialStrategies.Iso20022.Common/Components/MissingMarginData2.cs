// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the outstanding derivatives for which no margin or outdated margin information has been reported.
/// </summary>
[IsoId("_rtPOiVowEe23K4GXSpBSeg")]
[DisplayName("Missing Margin Data")]
public partial record MissingMarginData2
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_rud9kVowEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData92 CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Number of outstanding derivatives. 
    /// </summary>
    [IsoId("_rud9k1owEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives")]
    [IsoXmlTag("NbOfOutsdngDerivs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
    
    /// <summary>
    /// Number of outstanding derivatives with no margin information.
    /// </summary>
    [IsoId("_rud9lVowEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives With No Margin Information")]
    [IsoXmlTag("NbOfOutsdngDerivsWthNoMrgnInf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    
    /// <summary>
    /// Number of outstanding derivatives with outdated margin information.
    /// </summary>
    [IsoId("_rud9l1owEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives With Outdated Margin Information")]
    [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdMrgnInf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    
    /// <summary>
    /// Details of missing margins per transaction.
    /// </summary>
    [IsoId("_rud9mVowEe23K4GXSpBSeg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public MissingMarginTransactionData2? TransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
