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
/// Details of a drawdown tranche.
/// </summary>
[IsoId("_9IEgwFNcEeijdq8ilaxyOA")]
[DisplayName("Drawdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Drawdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Drawdown1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Drawdown1( DrawdownType1Choice_ reqTrancheType )
    {
        TrancheType = reqTrancheType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of drawdown tranche.
    /// </summary>
    [IsoId("_K5HOwFNdEeijdq8ilaxyOA")]
    [DisplayName("Tranche Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrchTp")]
    #endif
    [IsoXmlTag("TrchTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DrawdownType1Choice_ TrancheType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DrawdownType1Choice_ TrancheType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrawdownType1Choice_ TrancheType { get; init; } 
    #else
    public DrawdownType1Choice_ TrancheType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the rules that are applicable to the drawdown. For example, in the UK market, the pre-A-day rule that was introduced on 6 April 2006.)
    /// </summary>
    [IsoId("_YigxwVNfEeijdq8ilaxyOA")]
    [DisplayName("Applicable Rules")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblRules")]
    #endif
    [IsoXmlTag("AplblRules")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApplicableRules1Choice_? ApplicableRules { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApplicableRules1Choice_? ApplicableRules { get; init; } 
    #else
    public ApplicableRules1Choice_? ApplicableRules { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the total transfer value covered by the drawdown.
    /// </summary>
    [IsoId("_mtcmcFNfEeijdq8ilaxyOA")]
    [DisplayName("Percentage Of Total Transfer Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfTtlTrfVal")]
    #endif
    [IsoXmlTag("PctgOfTtlTrfVal")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfTotalTransferValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfTotalTransferValue { get; init; } 
    #else
    public System.Decimal? PercentageOfTotalTransferValue { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that was originally designated for drawdown.
    /// </summary>
    [IsoId("_uPeNcFNfEeijdq8ilaxyOA")]
    [DisplayName("Total Amount Net Drawdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtNetDrwdwn")]
    #endif
    [IsoXmlTag("TtlAmtNetDrwdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountNetDrawdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountNetDrawdown { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountNetDrawdown { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether any additional funds have been designated since the original arrangement.
    /// </summary>
    [IsoId("_ClsfsFNgEeijdq8ilaxyOA")]
    [DisplayName("Additional Funds Designated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFndsDsgntd")]
    #endif
    [IsoXmlTag("AddtlFndsDsgntd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AdditionalFundsDesignated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalFundsDesignated { get; init; } 
    #else
    public System.String? AdditionalFundsDesignated { get; set; } 
    #endif
    
    /// <summary>
    /// Drawdown allowance check. For pensions that have a lifetime allowance, a check is made of the maximum value of benefits that may be taken from the pension without incurring a special tax. (This check or &apos;event&apos; is known as the benefit crystallisation event in the UK market.)
    /// </summary>
    [IsoId("_hNJmoFNfEeijdq8ilaxyOA")]
    [DisplayName("Drawdown Allowance Check")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrwdwnAllwncChck")]
    #endif
    [IsoXmlTag("DrwdwnAllwncChck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DrawdownAllowanceCheck1? DrawdownAllowanceCheck { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrawdownAllowanceCheck1? DrawdownAllowanceCheck { get; init; } 
    #else
    public DrawdownAllowanceCheck1? DrawdownAllowanceCheck { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the pension commencement lump sum (PCLS) remaining.
    /// </summary>
    [IsoId("_hCjj8LpcEeij7vHPZxBWhA")]
    [DisplayName("Pension Commencement Lump Sum Remaining")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PnsnCmcmntLumpSumRmng")]
    #endif
    [IsoXmlTag("PnsnCmcmntLumpSumRmng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? PensionCommencementLumpSumRemaining { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? PensionCommencementLumpSumRemaining { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? PensionCommencementLumpSumRemaining { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the pension commencement lump sum (PCLS) must be used.
    /// </summary>
    [IsoId("_jYEp0LpcEeij7vHPZxBWhA")]
    [DisplayName("Pension Commencement Lump Sum Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PnsnCmcmntLumpSumDt")]
    #endif
    [IsoXmlTag("PnsnCmcmntLumpSumDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PensionCommencementLumpSumDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PensionCommencementLumpSumDate { get; init; } 
    #else
    public System.DateOnly? PensionCommencementLumpSumDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates there have been multiple pension commencement lump sum (PCLS) payments. 
    /// </summary>
    [IsoId("_tSJtULpcEeij7vHPZxBWhA")]
    [DisplayName("Multiple Pension Commencement Lump Sums")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MltplPnsnCmcmntLumpSums")]
    #endif
    [IsoXmlTag("MltplPnsnCmcmntLumpSums")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MultiplePensionCommencementLumpSums { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MultiplePensionCommencementLumpSums { get; init; } 
    #else
    public System.String? MultiplePensionCommencementLumpSums { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the lifetime allowance (LTA) used.
    /// </summary>
    [IsoId("_2dgpobpcEeij7vHPZxBWhA")]
    [DisplayName("Lifetime Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LftmAllwnc")]
    #endif
    [IsoXmlTag("LftmAllwnc")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? LifetimeAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LifetimeAllowance { get; init; } 
    #else
    public System.Decimal? LifetimeAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a person other than the original pension holder is the receiver of the drawdown payment.
    /// </summary>
    [IsoId("_8_IcgLGpEeirN-C08vro8Q")]
    [DisplayName("Recipient Of Drawdown Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptOfDrwdwnInd")]
    #endif
    [IsoXmlTag("RcptOfDrwdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RecipientOfDrawdownIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RecipientOfDrawdownIndicator { get; init; } 
    #else
    public System.String? RecipientOfDrawdownIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the recipient of the drawdown, when not the original pension holder.
    /// </summary>
    [IsoId("_h9sdUFNgEeijdq8ilaxyOA")]
    [DisplayName("Beneficiary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryDtls")]
    #endif
    [IsoXmlTag("BnfcryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryDrawdown1? BeneficiaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryDrawdown1? BeneficiaryDetails { get; init; } 
    #else
    public BeneficiaryDrawdown1? BeneficiaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Limits of the capped drawdown.
    /// </summary>
    [IsoId("_1dK1IFNdEeijdq8ilaxyOA")]
    [DisplayName("Capped Limits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CapdLmts")]
    #endif
    [IsoXmlTag("CapdLmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Capped1? CappedLimits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Capped1? CappedLimits { get; init; } 
    #else
    public Capped1? CappedLimits { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the drawdown was triggered when the drawdown type is flexible.
    /// </summary>
    [IsoId("_HEE24FNdEeijdq8ilaxyOA")]
    [DisplayName("Flexible Drawdown Triggered Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlxblDrwdwnTrggrdDt")]
    #endif
    [IsoXmlTag("FlxblDrwdwnTrggrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FlexibleDrawdownTriggeredDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FlexibleDrawdownTriggeredDate { get; init; } 
    #else
    public System.DateOnly? FlexibleDrawdownTriggeredDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the drawdown.
    /// </summary>
    [IsoId("_1Q6vkFNiEeijdq8ilaxyOA")]
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
