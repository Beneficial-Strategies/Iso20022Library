// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service provided by the ATM inside the session.
/// </summary>
[IsoId("_Mi7cMa4bEeW_TaP-ygI0SQ")]
[DisplayName("ATM Service")]
public record ATMService21
{
    /// <summary>
    /// Unique identification of the service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_MvTEQa4bEeW_TaP-ygI0SQ")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; }

    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_MvTEQ64bEeW_TaP-ygI0SQ")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; }

    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_MvTERa4bEeW_TaP-ygI0SQ")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; }

    /// <summary>
    /// Describes the type of withdrawal selected by the customer.
    /// </summary>
    [IsoId("_MvTER64bEeW_TaP-ygI0SQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType5Code ServiceType { get; init; }

    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_UK-ysK4bEeW_TaP-ygI0SQ")]
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceVariantIdentification { get; init; }
}
