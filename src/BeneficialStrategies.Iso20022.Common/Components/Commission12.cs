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
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_RsEeQ9p-Ed-ak6NoX_4Aeg_356134401")]
[DisplayName("Commission")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Commission12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Commission12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Commission12( CommissionType7Code reqType,System.String reqExtendedType,ActiveCurrencyAnd13DecimalAmount reqAmount )
    {
        Type = reqType;
        ExtendedType = reqExtendedType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_RsEeRNp-Ed-ak6NoX_4Aeg_356134419")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommissionType7Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommissionType7Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommissionType7Code Type { get; init; } 
    #else
    public CommissionType7Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_RsEeRdp-Ed-ak6NoX_4Aeg_356134444")]
    [DisplayName("Extended Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedTp")]
    #endif
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedType { get; init; } 
    #else
    public System.String ExtendedType { get; set; } 
    #endif
    
    /// <summary>
    /// Basis upon which a commission is charged, eg, flat fee.
    /// </summary>
    [IsoId("_RsEeRtp-Ed-ak6NoX_4Aeg_356134479")]
    [DisplayName("Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bsis")]
    #endif
    [IsoXmlTag("Bsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxationBasis4Code? Basis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxationBasis4Code? Basis { get; init; } 
    #else
    public TaxationBasis4Code? Basis { get; set; } 
    #endif
    
    /// <summary>
    /// Basis upon which a commission is charged, eg, flat fee.
    /// </summary>
    [IsoId("_RsEeR9p-Ed-ak6NoX_4Aeg_356134504")]
    [DisplayName("Extended Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedBsis")]
    #endif
    [IsoXmlTag("XtndedBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedBasis { get; init; } 
    #else
    public System.String? ExtendedBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_RsEeSNp-Ed-ak6NoX_4Aeg_356134539")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    [IsoId("_RsEeSdp-Ed-ak6NoX_4Aeg_356134574")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? RecipientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_RsNoMNp-Ed-ak6NoX_4Aeg_356134616")]
    [DisplayName("Commercial Agreement Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclAgrmtRef")]
    #endif
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommercialAgreementReference { get; init; } 
    #else
    public System.String? CommercialAgreementReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
