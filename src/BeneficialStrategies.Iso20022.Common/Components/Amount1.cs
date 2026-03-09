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
/// Margin amount payable by one party to the other party.
/// </summary>
[IsoId("_Ul4kBtp-Ed-ak6NoX_4Aeg_-2038049081")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amount1( ActiveCurrencyAndAmount reqAgreedAmount,System.String reqMarginCallRequestIdentification )
    {
        AgreedAmount = reqAgreedAmount;
        MarginCallRequestIdentification = reqMarginCallRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Undisputed amount of the margin call request.
    /// </summary>
    [IsoId("_Ul4kB9p-Ed-ak6NoX_4Aeg_-1514098340")]
    [DisplayName("Agreed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdAmt")]
    #endif
    [IsoXmlTag("AgrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount AgreedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount AgreedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for the margin call request.
    /// </summary>
    [IsoId("_UmCVANp-Ed-ak6NoX_4Aeg_419184137")]
    [DisplayName("Margin Call Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnCallReqId")]
    #endif
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MarginCallRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MarginCallRequestIdentification { get; init; } 
    #else
    public System.String MarginCallRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information related to the margin call amount that has been agreed.
    /// </summary>
    [IsoId("_UmCVAdp-Ed-ak6NoX_4Aeg_-131236975")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
