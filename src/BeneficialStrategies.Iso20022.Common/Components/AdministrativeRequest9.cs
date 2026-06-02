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
[IsoId("_qqEagbYCEfCUZfsQO4rYeA")]
[DisplayName("Administrative Request9")]
public record AdministrativeRequest9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_qq_AhbYCEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_qq_Ai7YCEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Identification of the administrative service to process.
    /// </summary>
    [IsoId("_qq_AkbYCEfCUZfsQO4rYeA")]
    [DisplayName("Administrative Service Identification")]
    [IsoXmlTag("AdmstvSvcId")]
    public IsoMax20000Text? AdministrativeServiceIdentification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_qq_Al7YCEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
