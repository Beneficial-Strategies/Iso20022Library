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
/// Specifies security rate details.
/// </summary>
[IsoId("_l5a7ceGcEd-1Ktb5rVaajw")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_l5a7c-GcEd-1Ktb5rVaajw")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForSbcbdRsltntScties")]
    #endif
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat11Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat11Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #else
    public RatioFormat11Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_l5a7deGcEd-1Ktb5rVaajw")]
    [DisplayName("Additional Quantity For Existing Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForExstgScties")]
    #endif
    [IsoXmlTag("AddtlQtyForExstgScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat11Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat11Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    #else
    public RatioFormat11Choice_? AdditionalQuantityForExistingSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_l5a7d-GcEd-1Ktb5rVaajw")]
    [DisplayName("New To Old")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewToOd")]
    #endif
    [IsoXmlTag("NewToOd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RatioFormat12Choice_? NewToOld { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RatioFormat12Choice_? NewToOld { get; init; } 
    #else
    public RatioFormat12Choice_? NewToOld { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    [IsoId("_l5a7e-GcEd-1Ktb5rVaajw")]
    [DisplayName("Transformation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfrmatnRate")]
    #endif
    [IsoXmlTag("TrfrmatnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TransformationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TransformationRate { get; init; } 
    #else
    public System.Decimal? TransformationRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
