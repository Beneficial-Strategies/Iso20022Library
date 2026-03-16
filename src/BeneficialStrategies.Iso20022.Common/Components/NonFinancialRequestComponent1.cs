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
[IsoId("_MeptkC_nEeugIJ3Gvoevmg")]
[DisplayName("Non Financial Request Component")]
public record NonFinancialRequestComponent1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_NlxRNC_oEeugIJ3Gvoevmg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_NlxRNS_oEeugIJ3Gvoevmg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Aim of the non financial request.
    /// </summary>
    [IsoId("_dkTxgC_oEeugIJ3Gvoevmg")]
    [DisplayName("Non Financial Request Content")]
    [IsoXmlTag("NonFinReqCntt")]
    public required NonFinancialRequestContentComponent1 NonFinancialRequestContent { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_NlxRNy_oEeugIJ3Gvoevmg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
