// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular triparty collateral instruction/transaction  can be confirmed. These parameters are defined by the instructing party in compliance with triparty collateral rules in the market the instruction/transaction will take place.
/// </summary>
[IsoId("_LgF2lSs9EeySlt9bF77XfA")]
[DisplayName("Collateral Parameters")]
public record CollateralParameters11
{
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_L3V48Ss9EeySlt9bF77XfA")]
    [DisplayName("Collateral Instruction Type")]
    [IsoXmlTag("CollInstrTp")]
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_L3V48ys9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType23Choice_ ExposureType { get; init; }

    /// <summary>
    /// Specifies whether the alleged side is the collateral taker or giver. So it will be the opposite  side of the instruction.
    /// </summary>
    [IsoId("_L3V49Ss9EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public required CollateralRole1Code CollateralSide { get; init; }

    /// <summary>
    /// Percentage by which the collateral value sought is increased, in selecting securities for a collateral basket, to reflect the taker&apos;s margin requirements.
    /// </summary>
    [IsoId("_L3V49ys9EeySlt9bF77XfA")]
    [DisplayName("Value Sought Margin Rate")]
    [IsoXmlTag("ValSghtMrgnRate")]
    public RateOrType1Choice_? ValueSoughtMarginRate { get; init; }

    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_L3V4-Ss9EeySlt9bF77XfA")]
    [DisplayName("Eligibility Set Profile")]
    [IsoXmlTag("ElgbltySetPrfl")]
    public GenericIdentification1? EligibilitySetProfile { get; init; }

    /// <summary>
    /// Change of title for the collateral. If N then collateral is pledged.
    /// </summary>
    [IsoId("_L3V4-ys9EeySlt9bF77XfA")]
    [DisplayName("Transfer Title")]
    [IsoXmlTag("TrfTitl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferTitle { get; init; }

    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_L3V4_Ss9EeySlt9bF77XfA")]
    [DisplayName("Settlement Process")]
    [IsoXmlTag("SttlmPrc")]
    public GenericIdentification30? SettlementProcess { get; init; }
}
