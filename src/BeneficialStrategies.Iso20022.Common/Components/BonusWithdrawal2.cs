// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a bonus paid out or a withdrawal.
/// </summary>
[IsoId("_y1unsZzGEembF9M4GR6EAA")]
[DisplayName("Bonus Withdrawal")]
public partial record BonusWithdrawal2
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the amount is the result of a bonus paid, a withdrawal or other kind of amount.
    /// </summary>
    [IsoId("_zJhGYZzGEembF9M4GR6EAA")]
    [DisplayName("Type Of Amount")]
    [IsoXmlTag("TpOfAmt")]
    public required TypeOfAmount1Choice_ TypeOfAmount { get; init; } 
    
    /// <summary>
    /// Amount of the bonus paid or the claimed amount. For example, a claimed amount for a lifetime ISA (LISA) or a government bonus paid out.
    /// </summary>
    [IsoId("_zJhGY5zGEembF9M4GR6EAA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    
    /// <summary>
    /// Reason for the bonus amount paid to or an amount withdrawn from the investment product.
    /// </summary>
    [IsoId("_zJhGZZzGEembF9M4GR6EAA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public WithdrawalReason1Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Amount of an unclaimed bonus or an unclaimed withdrawal.
    /// </summary>
    [IsoId("_zJhGZ5zGEembF9M4GR6EAA")]
    [DisplayName("Unclaimed Amount")]
    [IsoXmlTag("UclmdAmt")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? UnclaimedAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether there is an outstanding bonus or withdrawal amount.
    /// </summary>
    [IsoId("_zJhGaZzGEembF9M4GR6EAA")]
    [DisplayName("Outstanding")]
    [IsoXmlTag("Outsdng")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Outstanding { get; init; } 
    
    /// <summary>
    /// Identification of the withdrawal or bonus.
    /// </summary>
    [IsoId("_5u10kJzGEembF9M4GR6EAA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; } 
    
    /// <summary>
    /// Additional information about the monies paid out or withdrawn.
    /// </summary>
    [IsoId("_zJhGa5zGEembF9M4GR6EAA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
