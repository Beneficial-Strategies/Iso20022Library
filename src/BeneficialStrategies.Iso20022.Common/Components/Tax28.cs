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
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_CTMGESSEEeWdoOFYMt-Lzw")]
[DisplayName("Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tax28
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Tax28 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Tax28( TaxType1Choice_ reqType,ActiveOrHistoricCurrencyAnd13DecimalAmount reqAmount,System.String reqExemptionIndicator )
    {
        Type = reqType;
        Amount = reqAmount;
        ExemptionIndicator = reqExemptionIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_CvdLUySEEeWdoOFYMt-Lzw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType1Choice_ Type { get; init; } 
    #else
    public TaxType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_CvdLVSSEEeWdoOFYMt-Lzw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, for example, the purchase price.
    /// </summary>
    [IsoId("_CvdLVySEEeWdoOFYMt-Lzw")]
    [DisplayName("Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bsis")]
    #endif
    [IsoXmlTag("Bsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxBasis1Choice_? Basis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxBasis1Choice_? Basis { get; init; } 
    #else
    public TaxBasis1Choice_? Basis { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_CvdLWSSEEeWdoOFYMt-Lzw")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? RecipientIdentification { get; init; } 
    #else
    public PartyIdentification70Choice_? RecipientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_CvdLWySEEeWdoOFYMt-Lzw")]
    [DisplayName("Exemption Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnInd")]
    #endif
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExemptionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExemptionIndicator { get; init; } 
    #else
    public System.String ExemptionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_CvdLXSSEEeWdoOFYMt-Lzw")]
    [DisplayName("Exemption Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnRsn")]
    #endif
    [IsoXmlTag("XmptnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExemptionReason1Choice_? ExemptionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExemptionReason1Choice_? ExemptionReason { get; init; } 
    #else
    public ExemptionReason1Choice_? ExemptionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_CvdLXySEEeWdoOFYMt-Lzw")]
    [DisplayName("Tax Calculation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctnDtls")]
    #endif
    [IsoXmlTag("TaxClctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCalculationInformation8? TaxCalculationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCalculationInformation8? TaxCalculationDetails { get; init; } 
    #else
    public TaxCalculationInformation8? TaxCalculationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
