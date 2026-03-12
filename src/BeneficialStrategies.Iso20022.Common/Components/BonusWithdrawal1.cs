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
[IsoId("_K37R0F23EeiFXdiLi_Nf4A")]
[DisplayName("Bonus Withdrawal")]
public partial record BonusWithdrawal1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the amount is the result of a bonus paid, a withdrawal or other kind of amount.
    /// </summary>
    [IsoId("_YnYO8F24EeiFXdiLi_Nf4A")]
    [DisplayName("Type Of Amount")]
    [IsoXmlTag("TpOfAmt")]
    public required TypeOfAmount1Choice_ TypeOfAmount { get; init; } 
    
    /// <summary>
    /// Amount of the bonus paid or the claimed amount. For example, a claimed amount for a lifetime ISA (LISA) or a government bonus paid out.
    /// </summary>
    [IsoId("_Q-AfRF23EeiFXdiLi_Nf4A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    
    /// <summary>
    /// Reason for the bonus amount paid to or an amount withdrawn from the investment product.
    /// </summary>
    [IsoId("_Q-AfRl23EeiFXdiLi_Nf4A")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public WithdrawalReason1Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Amount of an unclaimed bonus or an unclaimed withdrawal.
    /// </summary>
    [IsoId("_Q-AfRV23EeiFXdiLi_Nf4A")]
    [DisplayName("Unclaimed Amount")]
    [IsoXmlTag("UclmdAmt")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? UnclaimedAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether there is an outstanding bonus or withdrawal amount.
    /// </summary>
    [IsoId("_Q-AfR123EeiFXdiLi_Nf4A")]
    [DisplayName("Outstanding")]
    [IsoXmlTag("Outsdng")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Outstanding { get; init; } 
    
    /// <summary>
    /// Additional information about the monies paid out or withdrawn.
    /// </summary>
    [IsoId("_u-KIsZDGEeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
