// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial request.
/// </summary>
[IsoId("_4bs1QC_pEeugIJ3Gvoevmg")]
[DisplayName("Non Financial Request Content Component")]
public record NonFinancialRequestContentComponent1
{
    /// <summary>
    /// Type of non financial request that the Acceptor wants to be processed.
    /// </summary>
    [IsoId("_yZV_UC_rEeugIJ3Gvoevmg")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public SimpleValueList<NonFinancialRequestType1Code> NonFinancialRequestType { get; init; } =
        [];

    // ID for the above is _yZV_UC_rEeugIJ3Gvoevmg

    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_HDGRkC_sEeugIJ3Gvoevmg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardPaymentTransaction107? Transaction { get; init; }
}
