// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the movement instruction.
/// </summary>
[IsoId("_UIh5p9p-Ed-ak6NoX_4Aeg_378115287")]
[DisplayName("Corporate Action Movement")]
public record CorporateActionMovement1
{
    /// <summary>
    /// Type of movement instruction.
    /// </summary>
    [IsoId("_UIh5qNp-Ed-ak6NoX_4Aeg_-2043026968")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public required DistributionInstructionType1Code OrderType { get; init; }

    /// <summary>
    /// Indicates whether the movement is a high priority or not.|Meaning when true: High priority|Meaning when false: Standard.
    /// </summary>
    [IsoId("_UIh5qdp-Ed-ak6NoX_4Aeg_1947921085")]
    [DisplayName("High Priority Indicator")]
    [IsoXmlTag("HghPrtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator HighPriorityIndicator { get; init; }

    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UIh5qtp-Ed-ak6NoX_4Aeg_1390292817")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UIh5q9p-Ed-ak6NoX_4Aeg_1390292847")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CorporateActionOption1FormatChoice_? OptionType { get; init; }

    /// <summary>
    /// Date at which the distribution movement must be executed.
    /// </summary>
    [IsoId("_UIh5rNp-Ed-ak6NoX_4Aeg_1481723517")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_UIrqoNp-Ed-ak6NoX_4Aeg_-780577191")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; }

    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_UIrqodp-Ed-ak6NoX_4Aeg_1208775765")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Quantity of securities in the confirmed balance, ie, the balance to which the credit of the outturned resources applies.
    /// </summary>
    [IsoId("_UIrqotp-Ed-ak6NoX_4Aeg_-298927794")]
    [DisplayName("Confirmed Balance Securities Quantity")]
    [IsoXmlTag("ConfdBalSctiesQty")]
    public UnitOrFaceAmount1Choice_? ConfirmedBalanceSecuritiesQuantity { get; init; }
}
