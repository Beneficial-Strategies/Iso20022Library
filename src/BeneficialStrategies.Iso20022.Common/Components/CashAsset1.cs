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
[IsoId("_e2IPAEyHEeir2sRRVd9XhA")]
[DisplayName("Cash Asset")]
public record CashAsset1
{
    /// <summary>
    /// Type of cash asset.
    /// </summary>
    [IsoId("_VrtRYEyIEeir2sRRVd9XhA")]
    [DisplayName("Cash Asset Type")]
    [IsoXmlTag("CshAsstTp")]
    public required CashAssetType1Choice_ CashAssetType { get; init; }

    /// <summary>
    /// Additional information about the cash asset.
    /// </summary>
    [IsoId("_cMk9YEyIEeir2sRRVd9XhA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
