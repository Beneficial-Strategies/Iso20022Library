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
/// Additional information required for distribution in the German market.
/// </summary>
[IsoId("_Z1vAIM2rEeuAE-cYsQdwHQ")]
[DisplayName("Additional Product Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalProductInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Category of fund product.  When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09000.
    /// </summary>
    [IsoId("_1fDskM2rEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Category German Fund Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ESGCtgyGrmnFndMkt")]
    #endif
    [IsoXmlTag("ESGCtgyGrmnFndMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ESGCategoryGermanFundMarket1Code? ESGCategoryGermanFundMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ESGCategoryGermanFundMarket1Code? ESGCategoryGermanFundMarket { get; init; } 
    #else
    public ESGCategoryGermanFundMarket1Code? ESGCategoryGermanFundMarket { get; set; } 
    #endif
    
    /// <summary>
    /// Category of structured securities product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09000.
    /// </summary>
    [IsoId("_5mXgMM2rEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Category German Structured Securities Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ESGCtgyGrmnStrdSctiesMkt")]
    #endif
    [IsoXmlTag("ESGCtgyGrmnStrdSctiesMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ESGCategoryGermanStructuredSecuritiesMarket1Code? ESGCategoryGermanStructuredSecuritiesMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ESGCategoryGermanStructuredSecuritiesMarket1Code? ESGCategoryGermanStructuredSecuritiesMarket { get; init; } 
    #else
    public ESGCategoryGermanStructuredSecuritiesMarket1Code? ESGCategoryGermanStructuredSecuritiesMarket { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the focus will be Environmental, Social or Governance.  When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09010.
    /// </summary>
    [IsoId("_8e2wQM2rEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Focus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ESGFcs")]
    #endif
    [IsoXmlTag("ESGFcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ESGFocus1Code? ESGFocus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ESGFocus1Code? ESGFocus { get; init; } 
    #else
    public ESGFocus1Code? ESGFocus { get; set; } 
    #endif
    
    /// <summary>
    /// ESG label or standard of a product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09020.
    /// </summary>
    [IsoId("_D4f3UM2sEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Label Or Standard")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ESGLablOrStd")]
    #endif
    [IsoXmlTag("ESGLablOrStd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ESGLabelOrStandard1Code? ESGLabelOrStandard { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ESGLabelOrStandard1Code? ESGLabelOrStandard { get; init; } 
    #else
    public ESGLabelOrStandard1Code? ESGLabelOrStandard { get; set; } 
    #endif
    
    
    #nullable disable
    
}
