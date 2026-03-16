// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the valuation details per counterparty aggregation.
/// </summary>
[IsoId("_SZLjaSs_EeySlt9bF77XfA")]
[DisplayName("Counterparty Aggregation")]
public record CounterpartyAggregation3
{
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_SwlWxSs_EeySlt9bF77XfA")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType6Choice_? OptionType { get; init; }

    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable repo.
    /// </summary>
    [IsoId("_SwlWxys_EeySlt9bF77XfA")]
    [DisplayName("Termination Option")]
    [IsoXmlTag("TermntnOptn")]
    public RepoTerminationOption1Code? TerminationOption { get; init; }

    /// <summary>
    /// Provides information on the baskets identification and the Eligiblity Set Profile.
    /// </summary>
    [IsoId("_SwlWySs_EeySlt9bF77XfA")]
    [DisplayName("Basket Identification And Eligibility Set Profile")]
    [IsoXmlTag("BsktIdAndElgbltySetPrfl")]
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; init; }

    /// <summary>
    /// Provides  the identification of the party or parties associated with the collateral agreement
    /// </summary>
    [IsoId("_SwlWyys_EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties11 CollateralParties { get; init; }

    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_SwlWzSs_EeySlt9bF77XfA")]
    [DisplayName("Valuation Amounts")]
    [IsoXmlTag("ValtnAmts")]
    public ValueList<CollateralAmount16> ValuationAmounts { get; init; } = [];

    // ID for the above is _SwlWzSs_EeySlt9bF77XfA

    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_SwlWzys_EeySlt9bF77XfA")]
    [DisplayName("Margin Rate")]
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MarginRate { get; init; }

    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions against counterparty.
    /// </summary>
    [IsoId("_SwlW0Ss_EeySlt9bF77XfA")]
    [DisplayName("Global Counterparty Status")]
    [IsoXmlTag("GblCtrPtySts")]
    public CollateralStatus1Code? GlobalCounterpartyStatus { get; init; }
}
