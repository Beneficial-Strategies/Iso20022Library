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
/// Individual cost or charge associated with the distribution or selling of a financial instrument. It may be one-off or recurring charge. It may be intended (ex ante) or actual (ex post).
/// </summary>
[IsoId("_p37YMZ9BEeqxTNfi5y7ywQ")]
[DisplayName("Individual Cost Or Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualCostOrCharge2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualCostOrCharge2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualCostOrCharge2( ChargeType8Choice_ reqCostType,IntendedOrActual2Code reqExAnteOrExPost )
    {
        CostType = reqCostType;
        ExAnteOrExPost = reqExAnteOrExPost;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of cost or charge.
    /// </summary>
    [IsoId("_qPIXNZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Cost Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CostTp")]
    #endif
    [IsoXmlTag("CostTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType8Choice_ CostType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType8Choice_ CostType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType8Choice_ CostType { get; init; } 
    #else
    public ChargeType8Choice_ CostType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the cost or charge is ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_qPIXN59BEeqxTNfi5y7ywQ")]
    [DisplayName("Ex Ante Or Ex Post")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExAnteOrExPst")]
    #endif
    [IsoXmlTag("ExAnteOrExPst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntendedOrActual2Code ExAnteOrExPost { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntendedOrActual2Code ExAnteOrExPost { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntendedOrActual2Code ExAnteOrExPost { get; init; } 
    #else
    public IntendedOrActual2Code ExAnteOrExPost { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the cost or charge.
    /// </summary>
    [IsoId("_qPIXOZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a negative amount.
    /// </summary>
    [IsoId("_-0re4Z9BEeqxTNfi5y7ywQ")]
    [DisplayName("Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgn")]
    #endif
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sign { get; init; } 
    #else
    public System.String? Sign { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cost or charge.
    /// </summary>
    [IsoId("_qPIXO59BEeqxTNfi5y7ywQ")]
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
    /// Start date and end date of the reference period for the ex post cost or charge. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08090 and 08100.
    /// </summary>
    [IsoId("_qPIXPZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Reference Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPrd")]
    #endif
    [IsoXmlTag("RefPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period15? ReferencePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period15? ReferencePeriod { get; init; } 
    #else
    public Period15? ReferencePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the individual cost or charge.
    /// </summary>
    [IsoId("_qPIXP59BEeqxTNfi5y7ywQ")]
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
