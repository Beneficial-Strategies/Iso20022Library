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
[IsoId("_sH2tUYqpEeS4a4abTJTSSw")]
[DisplayName("ATM Service")]
public record ATMService3
{
    /// <summary>
    /// Unique identification of the service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_sTxpcYqpEeS4a4abTJTSSw")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; }

    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_sTxpc4qpEeS4a4abTJTSSw")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; }

    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_ohNkICuGEeWQA7_Ib0etZg")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; }

    /// <summary>
    /// Describes the type of transaction selected by the customer.
    /// </summary>
    [IsoId("_sTxpdYqpEeS4a4abTJTSSw")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType2Code ServiceType { get; init; }
}
