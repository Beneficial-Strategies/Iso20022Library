// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal service provided by the ATM inside the session.
/// </summary>
[IsoId("_htdPUa4SEeWZgJQOa6iKCQ")]
[DisplayName("ATM Service")]
public record ATMService14
{
    /// <summary>
    /// Unique identification of the service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_h4Cusa4SEeWZgJQOa6iKCQ")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; }

    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_h4Cus64SEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; }

    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_h4Cuta4SEeWZgJQOa6iKCQ")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; }

    /// <summary>
    /// Describes the type of transaction selected by the customer.
    /// </summary>
    [IsoId("_h4Cut64SEeWZgJQOa6iKCQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType7Code ServiceType { get; init; }

    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_zFfSIK4SEeWZgJQOa6iKCQ")]
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    public SimpleValueList<IsoMax35Text> ServiceVariantIdentification { get; init; } = [];
}
