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
/// Fees not included in the transaction.
/// </summary>
[IsoId("_xv70MYdGEeuBS50MFjViNw")]
[DisplayName("Additional Fee")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalFee2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalFee2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalFee2( TypeOfAmount21Code reqType,FeeAmount3 reqFeeAmount )
    {
        Type = reqType;
        FeeAmount = reqFeeAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type or class of fee.
    /// </summary>
    [IsoId("_x1HPIYdGEeuBS50MFjViNw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount21Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount21Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount21Code Type { get; init; } 
    #else
    public TypeOfAmount21Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to specify the type of amount of fee.
    /// </summary>
    [IsoId("_x1HPI4dGEeuBS50MFjViNw")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of fee program.
    /// </summary>
    [IsoId("_x1HPJYdGEeuBS50MFjViNw")]
    [DisplayName("Fee Program")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeePrgm")]
    #endif
    [IsoXmlTag("FeePrgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FeeProgram { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FeeProgram { get; init; } 
    #else
    public System.String? FeeProgram { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of specific fee.
    /// </summary>
    [IsoId("_x1HPJ4dGEeuBS50MFjViNw")]
    [DisplayName("Fee Descriptor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeeDscrptr")]
    #endif
    [IsoXmlTag("FeeDscrptr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FeeDescriptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FeeDescriptor { get; init; } 
    #else
    public System.String? FeeDescriptor { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of one occurrence of the fee amount.
    /// </summary>
    [IsoId("_x1HPKYdGEeuBS50MFjViNw")]
    [DisplayName("Fee Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeeAmt")]
    #endif
    [IsoXmlTag("FeeAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FeeAmount3 FeeAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FeeAmount3 FeeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FeeAmount3 FeeAmount { get; init; } 
    #else
    public FeeAmount3 FeeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the fee amount in reconciliation currency.
    /// </summary>
    [IsoId("_CHQygIdIEeuBS50MFjViNw")]
    [DisplayName("Fee Reconciliation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeeRcncltnAmt")]
    #endif
    [IsoXmlTag("FeeRcncltnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FeeAmount3? FeeReconciliationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FeeAmount3? FeeReconciliationAmount { get; init; } 
    #else
    public FeeAmount3? FeeReconciliationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Short description of the fee amount.
    /// </summary>
    [IsoId("_x1HPK4dGEeuBS50MFjViNw")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_nKZbYTNJEeylu6lH-gut-A")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
