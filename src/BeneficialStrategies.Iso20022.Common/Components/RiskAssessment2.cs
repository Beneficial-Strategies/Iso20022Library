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
/// Indicates to the card issuer the level of risk associated with the transaction.
/// </summary>
[IsoId("_hh16scSsEeuBjv5G5kw00g")]
[DisplayName("Risk Assessment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RiskAssessment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Entity providing an intermediate result of a risk assessment process.
    /// </summary>
    [IsoId("_hm9rQcSsEeuBjv5G5kw00g")]
    [DisplayName("Risk Assessment Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskAssmntNtty")]
    #endif
    [IsoXmlTag("RskAssmntNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification200? RiskAssessmentEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification200? RiskAssessmentEntity { get; init; } 
    #else
    public PartyIdentification200? RiskAssessmentEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Type of risk assessment.
    /// </summary>
    [IsoId("_hm9rQ8SsEeuBjv5G5kw00g")]
    [DisplayName("Risk Assessment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskAssmntTp")]
    #endif
    [IsoXmlTag("RskAssmntTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RiskAssessmentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RiskAssessmentType { get; init; } 
    #else
    public System.String? RiskAssessmentType { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction is identified as high risk.
    /// </summary>
    [IsoId("_xNnQAMSsEeuBjv5G5kw00g")]
    [DisplayName("High Risk Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghRskTx")]
    #endif
    [IsoXmlTag("HghRskTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? HighRiskTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HighRiskTransaction { get; init; } 
    #else
    public System.String? HighRiskTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for indicating a certain level of risk for the transaction.
    /// </summary>
    [IsoId("_hm9rRcSsEeuBjv5G5kw00g")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Risk assessment result.
    /// </summary>
    [IsoId("_hm9rR8SsEeuBjv5G5kw00g")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Result { get; init; } 
    #else
    public System.String? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions noted for the risk assessment.
    /// </summary>
    [IsoId("_3xgWYMVSEeuPIIgba4mCug")]
    [DisplayName("Risk Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskCond")]
    #endif
    [IsoXmlTag("RskCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? RiskCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? RiskCondition { get; init; } 
    #else
    public AdditionalData1? RiskCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional risk data associated with the transaction.
    /// </summary>
    [IsoId("_hm9rScSsEeuBjv5G5kw00g")]
    [DisplayName("Additional Risk Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRskData")]
    #endif
    [IsoXmlTag("AddtlRskData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalRiskData1? AdditionalRiskData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalRiskData1? AdditionalRiskData { get; init; } 
    #else
    public AdditionalRiskData1? AdditionalRiskData { get; set; } 
    #endif
    
    /// <summary>
    /// Recommended action based on risk assessment.
    /// </summary>
    [IsoId("_hm9rS8SsEeuBjv5G5kw00g")]
    [DisplayName("Recommended Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcmmnddActn")]
    #endif
    [IsoXmlTag("RcmmnddActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionType8Code? RecommendedAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionType8Code? RecommendedAction { get; init; } 
    #else
    public ActionType8Code? RecommendedAction { get; set; } 
    #endif
    
    /// <summary>
    /// Other recommended action based on risk assessment defined at national or private level.
    /// </summary>
    [IsoId("_hm9rTcSsEeuBjv5G5kw00g")]
    [DisplayName("Other Recommended Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRcmmnddActn")]
    #endif
    [IsoXmlTag("OthrRcmmnddActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherRecommendedAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherRecommendedAction { get; init; } 
    #else
    public System.String? OtherRecommendedAction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional details of recommended action or other recommended action. 
    /// </summary>
    [IsoId("_hm9rT8SsEeuBjv5G5kw00g")]
    [DisplayName("Recommended Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcmmnddActnDtls")]
    #endif
    [IsoXmlTag("RcmmnddActnDtls")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? RecommendedActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RecommendedActionDetails { get; init; } 
    #else
    public System.String? RecommendedActionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
