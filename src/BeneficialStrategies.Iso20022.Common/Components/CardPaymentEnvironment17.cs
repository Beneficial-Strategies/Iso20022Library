// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the diagnostic exchange.
/// </summary>
[IsoId("_TA70sRz1EeK5OKMB21JFBg")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment17
{
    /// <summary>
    /// Version of acquirer configuration parameters.
    /// </summary>
    [IsoId("_TNIdoRz1EeK5OKMB21JFBg")]
    [DisplayName("Acquirer Parameters Version")]
    [IsoXmlTag("AcqrrParamsVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AcquirerParametersVersion { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_TNIdpRz1EeK5OKMB21JFBg")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI requesting the diagnostic.
    /// </summary>
    [IsoId("_TNIdqRz1EeK5OKMB21JFBg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; }
}
