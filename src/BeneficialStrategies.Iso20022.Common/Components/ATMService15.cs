// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry service provided by the ATM inside the session.
/// </summary>
[IsoId("_-C7vwa4VEeW_TaP-ygI0SQ")]
[DisplayName("ATM Service")]
public record ATMService15
{
    /// <summary>
    /// Unique identification of the withdrawal service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_-N1YMa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; }

    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_-N1YM64VEeW_TaP-ygI0SQ")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; }

    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    [IsoId("_-N1YNa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType3Code ServiceType { get; init; }

    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_HUrn8K4WEeW_TaP-ygI0SQ")]
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    public SimpleValueList<IsoMax35Text> ServiceVariantIdentification { get; init; } = [];
}
