// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a switch leg that is rejected or repaired.
/// </summary>
[IsoId("_RGg6Idp-Ed-ak6NoX_4Aeg_-513972542")]
[DisplayName("Switch Leg References")]
public record SwitchLegReferences1
{
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_RGg6Itp-Ed-ak6NoX_4Aeg_-325572706")]
    [DisplayName("Redemption Leg Identification")]
    [IsoXmlTag("RedLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RedemptionLegIdentification { get; init; }

    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_RGg6I9p-Ed-ak6NoX_4Aeg_-371751546")]
    [DisplayName("Subscription Leg Identification")]
    [IsoXmlTag("SbcptLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SubscriptionLegIdentification { get; init; }

    /// <summary>
    /// Additional information about the reason for the rejection of a leg.
    /// </summary>
    [IsoId("_RGg6JNp-Ed-ak6NoX_4Aeg_17053572")]
    [DisplayName("Leg Rejection Reason")]
    [IsoXmlTag("LegRjctnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? LegRejectionReason { get; init; }

    /// <summary>
    /// Elements from the original switch order that have been repaired so that the switch order can be accepted.
    /// </summary>
    [IsoId("_RGg6Jdp-Ed-ak6NoX_4Aeg_1991932087")]
    [DisplayName("Repaired Conditions")]
    [IsoXmlTag("RprdConds")]
    public RepairedConditions3? RepairedConditions { get; init; }

    /// <summary>
    /// Account identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_RGg6Jtp-Ed-ak6NoX_4Aeg_1676085552")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount13? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Financial instrument identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_RGg6J9p-Ed-ak6NoX_4Aeg_1674239005")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; }
}
