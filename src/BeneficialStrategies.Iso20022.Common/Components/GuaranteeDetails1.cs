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
/// Indicates the details of a guarantee.
/// </summary>
[IsoId("_OTgzMzc0-AOSNFX-8224501")]
[DisplayName("Guarantee Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GuaranteeDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party issuing the guarantee.
    /// </summary>
    [IsoId("_OTgzMzg4-AOSNFX-8224502")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    #else
    public QualifiedPartyIdentification1? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Rank of the guarantee provider. A value of 1 means highest rank. Providers may have the same position.
    /// </summary>
    [IsoId("_OTgzMzg5-AOSNFX-8224502")]
    [DisplayName("Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pos")]
    #endif
    [IsoXmlTag("Pos")]
    [IsoSimpleType(IsoSimpleType.positiveInteger)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsopositiveInteger? Position { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Position { get; init; } 
    #else
    public System.String? Position { get; set; } 
    #endif
    
    /// <summary>
    /// Textual description of guarantee details.
    /// </summary>
    [IsoId("_OTgzMzkw-AOSNFX-8224502")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Amount by time periods, maximum value applies at any given date.
    /// </summary>
    [IsoId("_OTgzMzkx-AOSNFX-8224502")]
    [DisplayName("Guaranteed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntedAmt")]
    #endif
    [IsoXmlTag("GrntedAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndPeriod1? GuaranteedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndPeriod1? GuaranteedAmount { get; init; } 
    #else
    public AmountAndPeriod1? GuaranteedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount not covered by the guarantee. Maximum value applies at any given date.
    /// </summary>
    [IsoId("_OTgzMzky-AOSNFX-8224502")]
    [DisplayName("Excess")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xcss")]
    #endif
    [IsoXmlTag("Xcss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndPeriod1? Excess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndPeriod1? Excess { get; init; } 
    #else
    public AmountAndPeriod1? Excess { get; set; } 
    #endif
    
    /// <summary>
    /// Covered percentage, the maximum value applies at any given date.
    /// </summary>
    [IsoId("_OTgzMzkz-AOSNFX-8224502")]
    [DisplayName("Covered Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CvrdPctg")]
    #endif
    [IsoXmlTag("CvrdPctg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PercentageAndPeriod1? CoveredPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PercentageAndPeriod1? CoveredPercentage { get; init; } 
    #else
    public PercentageAndPeriod1? CoveredPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMzk0-AOSNFX-8224502")]
    [DisplayName("Associated Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDoc")]
    #endif
    [IsoXmlTag("AssoctdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #else
    public QualifiedDocumentInformation1? AssociatedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the demand.
    /// </summary>
    [IsoId("_OTgzMzk1-AOSNFX-8224503")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
