// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the POI performing the transaction.
/// </summary>
[IsoId("_TGJWagEcEeCQm6a_G2yO_w_-1706794151")]
[DisplayName("Point Of Interaction Capabilities")]
public record PointOfInteractionCapabilities1
{
    /// <summary>
    /// Card reading capabilities of the POI performing the transaction.
    /// </summary>
    [IsoId("_TGJWawEcEeCQm6a_G2yO_w_477826154")]
    [DisplayName("Card Reading Capabilities")]
    [IsoXmlTag("CardRdngCpblties")]
    public CardDataReading1Code? CardReadingCapabilities { get; init; }

    /// <summary>
    /// Cardholder verification capabilities of the POI performing the transaction.
    /// </summary>
    [IsoId("_TGJWbAEcEeCQm6a_G2yO_w_1143315363")]
    [DisplayName("Cardholder Verification Capabilities")]
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; init; }

    /// <summary>
    /// On-line and off-line capabilities of the POI.
    /// </summary>
    [IsoId("_TGSgUAEcEeCQm6a_G2yO_w_1272910628")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability1Code? OnLineCapabilities { get; init; }

    /// <summary>
    /// Capabilities of the display components performing the transaction.
    /// </summary>
    [IsoId("_TGSgUQEcEeCQm6a_G2yO_w_666196014")]
    [DisplayName("Display Capabilities")]
    [IsoXmlTag("DispCpblties")]
    public DisplayCapabilities1? DisplayCapabilities { get; init; }

    /// <summary>
    /// Number of columns of the printer component.
    /// </summary>
    [IsoId("_TGSgUgEcEeCQm6a_G2yO_w_-1182970689")]
    [DisplayName("Print Line Width")]
    [IsoXmlTag("PrtLineWidth")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? PrintLineWidth { get; init; }
}
