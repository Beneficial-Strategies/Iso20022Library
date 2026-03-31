// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Select the type(s) of information to be retrieved about a registered investment account.
/// </summary>
[IsoId("_RR2AZNp-Ed-ak6NoX_4Aeg_1677189755")]
[DisplayName("Investment Account Information Type")]
public record InvestmentAccountInformationType1
{
    /// <summary>
    /// Indicates if the core investment account information must be selected.
    /// </summary>
    [IsoId("_RR2AZdp-Ed-ak6NoX_4Aeg_1677190067")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator InvestmentAccount { get; init; }

    /// <summary>
    /// Indicates if the information about account parties must be selected.
    /// </summary>
    [IsoId("_RR2AZtp-Ed-ak6NoX_4Aeg_1677190092")]
    [DisplayName("Account Parties")]
    [IsoXmlTag("AcctPties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AccountParties { get; init; }

    /// <summary>
    /// Indicates if the information about the intermediaries must be selected.
    /// </summary>
    [IsoId("_RR2AZ9p-Ed-ak6NoX_4Aeg_1677190127")]
    [DisplayName("Intermediaries")]
    [IsoXmlTag("Intrmies")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Intermediaries { get; init; }

    /// <summary>
    /// Indicates if the information about the investment plan(s) must be selected.
    /// </summary>
    [IsoId("_RR2AaNp-Ed-ak6NoX_4Aeg_1677190169")]
    [DisplayName("Investment Plan")]
    [IsoXmlTag("InvstmtPlan")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator InvestmentPlan { get; init; }

    /// <summary>
    /// Indicates if the cash settlement information must be selected.
    /// </summary>
    [IsoId("_RR2Aadp-Ed-ak6NoX_4Aeg_1677190470")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashSettlement { get; init; }

    /// <summary>
    /// Indicates if the Service Level Agreement information must be selected.
    /// </summary>
    [IsoId("_RR2Aatp-Ed-ak6NoX_4Aeg_1908994765")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ServiceLevelAgreement { get; init; }
}
