// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a market value.
/// </summary>
[IsoId("_kK-5sRIoEeyZaPkaPAzTvQ")]
[DisplayName("Collateral Transaction Amount Breakdown")]
public partial record CollateralTransactionAmountBreakdown2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the underlying transaction (exposure split).
    /// </summary>
    [IsoId("_kiYGARIoEeyZaPkaPAzTvQ")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public required GenericIdentification178 LotNumber { get; init; } 
    
    /// <summary>
    /// Split amount of the aggregate transaction amount (exposure).
    /// </summary>
    [IsoId("_kiYGCRIoEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; init; } 
    
    /// <summary>
    /// Period that applies to the aggregate transation amount (exposure).
    /// </summary>
    [IsoId("_kiYGCxIoEeyZaPkaPAzTvQ")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public Period4Choice_? Period { get; init; } 
    
    
    #nullable disable
    
}
