// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// </summary>
[IsoId("_PEDmAInwEeS9F4Qrq_eaVA")]
[DisplayName("ATM Message Function")]
public record ATMMessageFunction1
{
    /// <summary>
    /// Type of requested function.
    /// </summary>
    [IsoId("_7Tp2QInyEeS9F4Qrq_eaVA")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public required MessageFunction7Code Function { get; init; }

    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_KHqdIInzEeS9F4Qrq_eaVA")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; }

    /// <summary>
    /// Codification of the type of service for the ATM manager host.
    /// </summary>
    [IsoId("_M5XvwInzEeS9F4Qrq_eaVA")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; }
}
