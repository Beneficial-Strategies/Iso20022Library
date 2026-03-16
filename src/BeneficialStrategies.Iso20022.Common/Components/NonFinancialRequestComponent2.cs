// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the non financial request.
/// </summary>
[IsoId("_kSbj0U3kEey_VecAUE-C9Q")]
[DisplayName("Non Financial Request Component")]
public record NonFinancialRequestComponent2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_kZLsEU3kEey_VecAUE-C9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_kZLsE03kEey_VecAUE-C9Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Aim of the non financial request.
    /// </summary>
    [IsoId("_kZLsFU3kEey_VecAUE-C9Q")]
    [DisplayName("Non Financial Request Content")]
    [IsoXmlTag("NonFinReqCntt")]
    public required NonFinancialRequestContentComponent2 NonFinancialRequestContent { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_kZLsF03kEey_VecAUE-C9Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
