// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of admin service to be used with this message.
/// </summary>
[IsoId("_FpadcXJrEe299ZbWCkdR_w")]
[DisplayName("Administrative Request")]
public record AdministrativeRequest6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_FwTvoXJrEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_FwTvo3JrEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Identification of the administrative service to process.
    /// </summary>
    [IsoId("_FwTvpXJrEe299ZbWCkdR_w")]
    [DisplayName("Administrative Service Identification")]
    [IsoXmlTag("AdmstvSvcId")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? AdministrativeServiceIdentification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_FwTvp3JrEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
