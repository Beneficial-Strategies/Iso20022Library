// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the reconciliation for the acquirer.
/// </summary>
[IsoId("_kdGWgbvbEeKDMKF4Jf4bIg")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment19
{
    /// <summary>
    /// Acquirer involved in the card payment reconciliation.
    /// </summary>
    [IsoId("_knN70bvbEeKDMKF4Jf4bIg")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public required GenericIdentification32 AcquirerIdentification { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the reconciliation.
    /// </summary>
    [IsoId("_knN71bvbEeKDMKF4Jf4bIg")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI requesting the reconciliation.
    /// </summary>
    [IsoId("_knN72bvbEeKDMKF4Jf4bIg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }
}
