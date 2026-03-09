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
/// Amount of money associated with a service.
/// </summary>
[IsoId("_VIm2ktp-Ed-ak6NoX_4Aeg_32079845")]
[DisplayName("Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Charge10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Charge10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Charge10( ChargeType1 reqType,ActiveCurrencyAnd13DecimalAmount reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_VIm2k9p-Ed-ak6NoX_4Aeg_32079871")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType1 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType1 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType1 Type { get; init; } 
    #else
    public ChargeType1 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_VIm2lNp-Ed-ak6NoX_4Aeg_32080157")]
    [DisplayName("Charge Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBsis")]
    #endif
    [IsoXmlTag("ChrgBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxationBasis1? ChargeBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxationBasis1? ChargeBasis { get; init; } 
    #else
    public TaxationBasis1? ChargeBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_VIm2ldp-Ed-ak6NoX_4Aeg_32080139")]
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
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_VIm2ltp-Ed-ak6NoX_4Aeg_32080122")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Rate { get; init; } 
    #else
    public System.Decimal? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_VIm2l9p-Ed-ak6NoX_4Aeg_32080182")]
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
    
    
    #nullable disable
    
}
