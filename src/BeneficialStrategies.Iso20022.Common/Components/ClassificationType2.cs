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
/// Choice of format for the classification.
/// </summary>
[IsoId("_58Yc4eLVEeWFtOV72FbX9w")]
[DisplayName("Classification Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClassificationType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_6LaXYeLVEeWFtOV72FbX9w")]
    [DisplayName("Classification Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnFinInstrm")]
    #endif
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCFIOct2015Identifier? ClassificationFinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassificationFinancialInstrument { get; init; } 
    #else
    public System.String? ClassificationFinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the identification scheme, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_6LaXY-LVEeWFtOV72FbX9w")]
    [DisplayName("Financial Instrument Product Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmPdctTpCd")]
    #endif
    [IsoXmlTag("FinInstrmPdctTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalFinancialInstrumentProductType1Code? FinancialInstrumentProductTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? FinancialInstrumentProductTypeCode { get; init; } 
    #else
    public string? FinancialInstrumentProductTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary classification of financial instrument.
    /// </summary>
    [IsoId("_6LaXZeLVEeWFtOV72FbX9w")]
    [DisplayName("Alternate Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnClssfctn")]
    #endif
    [IsoXmlTag("AltrnClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification36? AlternateClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36? AlternateClassification { get; init; } 
    #else
    public GenericIdentification36? AlternateClassification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
