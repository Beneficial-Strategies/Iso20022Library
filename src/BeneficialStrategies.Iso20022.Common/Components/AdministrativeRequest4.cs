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
[IsoId("_EZpiAS5KEeunNvJlR_vCbg")]
[DisplayName("Administrative Request")]
public record AdministrativeRequest4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_EnkpQS5KEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_EnkpQy5KEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Identification of the administrative service to process.
    /// </summary>
    [IsoId("_EnkpRS5KEeunNvJlR_vCbg")]
    [DisplayName("Administrative Service Identification")]
    [IsoXmlTag("AdmstvSvcId")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? AdministrativeServiceIdentification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_EnkpRy5KEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
