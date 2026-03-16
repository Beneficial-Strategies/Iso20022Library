// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of formats to express the type of cash balance.
/// </summary>
[IsoId("_Rl0FQdp-Ed-ak6NoX_4Aeg_-1191454030")]
[DisplayName("Cash Balance Type 1 Format Type")]
public record CashBalanceType1FormatType
{
    /// <summary>
    /// Standard code to specify the type of cash balance.
    /// </summary>
    [IsoId("_Rl0FQtp-Ed-ak6NoX_4Aeg_736479285")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CashBalanceType1Code Code { get; init; }

    /// <summary>
    /// Proprietary code to express the type of cash balance.
    /// </summary>
    [IsoId("_Rl0FQ9p-Ed-ak6NoX_4Aeg_736479254")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public required GenericIdentification13 Proprietary { get; init; }
}
