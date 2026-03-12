// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cash asset.
/// </summary>
[IsoId("_T1_yMaPvEemf4IaGqCtquA")]
[DisplayName("Cash Asset")]
public partial record CashAsset3
{
    #nullable enable
    
    /// <summary>
    /// Type of cash asset.
    /// </summary>
    [IsoId("_UKrowaPvEemf4IaGqCtquA")]
    [DisplayName("Cash Asset Type")]
    [IsoXmlTag("CshAsstTp")]
    public required CashAssetType1Choice_ CashAssetType { get; init; } 
    
    /// <summary>
    /// Currency of the asset in the holding.
    /// </summary>
    [IsoId("_UKrow6PvEemf4IaGqCtquA")]
    [DisplayName("Holding Currency")]
    [IsoXmlTag("HldgCcy")]
    public required ActiveCurrencyCode HoldingCurrency { get; init; } 
    
    /// <summary>
    /// Currency of the asset in another currency.
    /// </summary>
    [IsoId("_UKroxaPvEemf4IaGqCtquA")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveCurrencyCode? TransferCurrency { get; init; } 
    
    /// <summary>
    /// Additional information about the cash asset.
    /// </summary>
    [IsoId("_UKrox6PvEemf4IaGqCtquA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
