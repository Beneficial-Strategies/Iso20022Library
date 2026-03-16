// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cash asset.
/// </summary>
[IsoId("_v2844ZNDEemQB_8XA98K0Q")]
[DisplayName("Cash Asset")]
public record CashAsset2
{
    /// <summary>
    /// Type of cash asset.
    /// </summary>
    [IsoId("_wLLccZNDEemQB_8XA98K0Q")]
    [DisplayName("Cash Asset Type")]
    [IsoXmlTag("CshAsstTp")]
    public required CashAssetType1Choice_ CashAssetType { get; init; }

    /// <summary>
    /// Currency of the asset in the holding.
    /// </summary>
    [IsoId("_PdRmYJNEEemQB_8XA98K0Q")]
    [DisplayName("Holding Currency")]
    [IsoXmlTag("HldgCcy")]
    public required ActiveCurrencyCode HoldingCurrency { get; init; }

    /// <summary>
    /// Additional information about the cash asset.
    /// </summary>
    [IsoId("_wLLcc5NDEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
