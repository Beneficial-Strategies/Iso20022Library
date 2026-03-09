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
/// Specifies the characteristics for a SEPA formatted payment initiation file.
/// </summary>
[IsoId("_XKhX0KA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel SEPA File")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelSEPAFile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelSEPAFile1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelSEPAFile1( System.String reqSEPAIndicator,System.String reqCategoryPurpose )
    {
        SEPAIndicator = reqSEPAIndicator;
        CategoryPurpose = reqCategoryPurpose;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the SEPA formatted file is compliant to the SEPA rulebook.
    /// </summary>
    [IsoId("_VfbZsMmREeWAGphE2LvqeA")]
    [DisplayName("SEPA Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SEPAInd")]
    #endif
    [IsoXmlTag("SEPAInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator SEPAIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SEPAIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SEPAIndicator { get; init; } 
    #else
    public System.String SEPAIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// High level category purpose of the payment initiation messages in the file, based on the SEPA rulebook.
    /// </summary>
    [IsoId("_aSMlIMmREeWAGphE2LvqeA")]
    [DisplayName("Category Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyPurp")]
    #endif
    [IsoXmlTag("CtgyPurp")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax6Text CategoryPurpose { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CategoryPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CategoryPurpose { get; init; } 
    #else
    public System.String CategoryPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Local market practices applicable to the SEPA file.
    /// </summary>
    [IsoId("_fdp9YMmREeWAGphE2LvqeA")]
    [DisplayName("Market Practices")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPrctcs")]
    #endif
    [IsoXmlTag("MktPrctcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<System.String> MarketPractices { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
