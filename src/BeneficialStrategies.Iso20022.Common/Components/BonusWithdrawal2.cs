// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a bonus paid out or a withdrawal.
/// </summary>
[IsoId("_y1unsZzGEembF9M4GR6EAA")]
[DisplayName("Bonus Withdrawal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BonusWithdrawal2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BonusWithdrawal2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BonusWithdrawal2( TypeOfAmount1Choice_ reqTypeOfAmount )
    {
        TypeOfAmount = reqTypeOfAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the amount is the result of a bonus paid, a withdrawal or other kind of amount.
    /// </summary>
    [IsoId("_zJhGYZzGEembF9M4GR6EAA")]
    [DisplayName("Type Of Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfAmt")]
    #endif
    [IsoXmlTag("TpOfAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount1Choice_ TypeOfAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount1Choice_ TypeOfAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount1Choice_ TypeOfAmount { get; init; } 
    #else
    public TypeOfAmount1Choice_ TypeOfAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the bonus paid or the claimed amount. For example, a claimed amount for a lifetime ISA (LISA) or a government bonus paid out.
    /// </summary>
    [IsoId("_zJhGY5zGEembF9M4GR6EAA")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the bonus amount paid to or an amount withdrawn from the investment product.
    /// </summary>
    [IsoId("_zJhGZZzGEembF9M4GR6EAA")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public WithdrawalReason1Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WithdrawalReason1Choice_? Reason { get; init; } 
    #else
    public WithdrawalReason1Choice_? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of an unclaimed bonus or an unclaimed withdrawal.
    /// </summary>
    [IsoId("_zJhGZ5zGEembF9M4GR6EAA")]
    [DisplayName("Unclaimed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UclmdAmt")]
    #endif
    [IsoXmlTag("UclmdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? UnclaimedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? UnclaimedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? UnclaimedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is an outstanding bonus or withdrawal amount.
    /// </summary>
    [IsoId("_zJhGaZzGEembF9M4GR6EAA")]
    [DisplayName("Outstanding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Outsdng")]
    #endif
    [IsoXmlTag("Outsdng")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Outstanding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Outstanding { get; init; } 
    #else
    public System.String? Outstanding { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the withdrawal or bonus.
    /// </summary>
    [IsoId("_5u10kJzGEembF9M4GR6EAA")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the monies paid out or withdrawn.
    /// </summary>
    [IsoId("_zJhGa5zGEembF9M4GR6EAA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
