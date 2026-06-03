// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides supplementary data for corporate action rates.
/// </summary>
[IsoId("_mX1VMLskEfCWCehgFzyN4w")]
[DisplayName("Corporate Action Rate SD12")]
public record CorporateActionRateSD12
{
    /// <summary>
    /// Unambiguous reference to the location/name of a document.
    /// </summary>
    [IsoId("_mX1VNLskEfCWCehgFzyN4w")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Rate declared by the security issuer.
    /// </summary>
    [IsoId("_mX1VOLskEfCWCehgFzyN4w")]
    [DisplayName("Declared Security Rate")]
    [IsoXmlTag("DclrdSctyRate")]
    public CorporateActionRateSD8Choice_? DeclaredSecurityRate { get; init; }

    /// <summary>
    /// Indicates whether the rate is estimated.
    /// </summary>
    [IsoId("_mX1VPLskEfCWCehgFzyN4w")]
    [DisplayName("Estimated Rate Flag")]
    [IsoXmlTag("EstmtdRateFlg")]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; }

    /// <summary>
    /// Rate of the fee declared by the issuer.
    /// </summary>
    [IsoId("_mX1VQLskEfCWCehgFzyN4w")]
    [DisplayName("Declared Fee Rate")]
    [IsoXmlTag("DclrdFeeRate")]
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; }
}
