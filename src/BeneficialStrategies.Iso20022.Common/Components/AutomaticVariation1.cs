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
/// Variation parameters and triggers.
/// </summary>
[IsoId("_9yyli3ltEeG7BsjMvd1mEw_-1016607830")]
[DisplayName("Automatic Variation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AutomaticVariation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AutomaticVariation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AutomaticVariation1( System.String reqIdentification,VariationType1Code reqType )
    {
        Identification = reqIdentification;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the automatic variation.
    /// </summary>
    [IsoId("_9yyljHltEeG7BsjMvd1mEw_-276845926")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of variation.
    /// </summary>
    [IsoId("_9yyljXltEeG7BsjMvd1mEw_-770869744")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VariationType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VariationType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VariationType1Code Type { get; init; } 
    #else
    public VariationType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the variation amount and its trigger.
    /// </summary>
    [IsoId("_9y7vcHltEeG7BsjMvd1mEw_-1036746610")]
    [DisplayName("Amount And Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtAndTrggr")]
    #endif
    [IsoXmlTag("AmtAndTrggr")]
    public ValueList<AmountAndTrigger1> AmountAndTrigger { get; init; } = new ValueList<AmountAndTrigger1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _9y7vcHltEeG7BsjMvd1mEw_-1036746610
    
    /// <summary>
    /// Additional information related to the variation.
    /// </summary>
    [IsoId("_9y7vcXltEeG7BsjMvd1mEw_-469370329")]
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
