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
/// Restrictions, remarks or notes that may be applied to an account or investment plan.
/// </summary>
[IsoId("_yM6pYUzZEea8fovz_9xSTQ")]
[DisplayName("Additiononal Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditiononalInformation12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Restrictions and/or limitations on the account or party.
    /// </summary>
    [IsoId("_ymNTIUzZEea8fovz_9xSTQ")]
    [DisplayName("Limitation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lmttn")]
    #endif
    [IsoXmlTag("Lmttn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Limitation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Limitation { get; init; } 
    #else
    public System.String? Limitation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the account management activity or party.
    /// </summary>
    [IsoId("_ymNTI0zZEea8fovz_9xSTQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information or instructions for the by-passing of validations in the account registration process.
    /// </summary>
    [IsoId("_ymNTJUzZEea8fovz_9xSTQ")]
    [DisplayName("Account Validation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctVldtn")]
    #endif
    [IsoXmlTag("AcctVldtn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AccountValidation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountValidation { get; init; } 
    #else
    public System.String? AccountValidation { get; set; } 
    #endif
    
    /// <summary>
    /// Type or identification of the remark, note, limitation or restriction.
    /// </summary>
    [IsoId("_ymNTJ0zZEea8fovz_9xSTQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Regulator that may have to be informed about the remark, note, limitation or restriction.
    /// </summary>
    [IsoId("_ymNTKUzZEea8fovz_9xSTQ")]
    [DisplayName("Regulator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rgltr")]
    #endif
    [IsoXmlTag("Rgltr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? Regulator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? Regulator { get; init; } 
    #else
    public PartyIdentification70Choice_? Regulator { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the remark, note, limitation or restriction.
    /// </summary>
    [IsoId("_ymNTK0zZEea8fovz_9xSTQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictionStatus1Choice_? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictionStatus1Choice_? Status { get; init; } 
    #else
    public RestrictionStatus1Choice_? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Period of the restriction.
    /// </summary>
    [IsoId("_ymNTLUzZEea8fovz_9xSTQ")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriodDetails1? Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriodDetails1? Period { get; init; } 
    #else
    public DateTimePeriodDetails1? Period { get; set; } 
    #endif
    
    
    #nullable disable
    
}
