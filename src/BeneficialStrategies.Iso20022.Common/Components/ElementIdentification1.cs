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
/// Description of the element that creates the mismatch.
/// </summary>
[IsoId("_RJf8s9p-Ed-ak6NoX_4Aeg_1263580782")]
[DisplayName("Element Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ElementIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ElementIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ElementIdentification1( System.String reqDocumentIndex,System.String reqElementPath,System.String reqElementName )
    {
        DocumentIndex = reqDocumentIndex;
        ElementPath = reqElementPath;
        ElementName = reqElementName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Refers to the identification number of the document in which the mismatch was found.
    /// </summary>
    [IsoId("_RJf8tNp-Ed-ak6NoX_4Aeg_-1274214222")]
    [DisplayName("Document Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocIndx")]
    #endif
    [IsoXmlTag("DocIndx")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText DocumentIndex { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DocumentIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DocumentIndex { get; init; } 
    #else
    public System.String DocumentIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies from the root of the message the complete path of the element that violated a rule.
    /// </summary>
    [IsoId("_RJf8tdp-Ed-ak6NoX_4Aeg_1320841192")]
    [DisplayName("Element Path")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElmtPth")]
    #endif
    [IsoXmlTag("ElmtPth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text ElementPath { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ElementPath { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ElementPath { get; init; } 
    #else
    public System.String ElementPath { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the element.
    /// </summary>
    [IsoId("_RJf8ttp-Ed-ak6NoX_4Aeg_-1433356393")]
    [DisplayName("Element Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElmtNm")]
    #endif
    [IsoXmlTag("ElmtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ElementName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ElementName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ElementName { get; init; } 
    #else
    public System.String ElementName { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the element.
    /// </summary>
    [IsoId("_RJf8t9p-Ed-ak6NoX_4Aeg_1327304238")]
    [DisplayName("Element Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElmtVal")]
    #endif
    [IsoXmlTag("ElmtVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ElementValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ElementValue { get; init; } 
    #else
    public System.String? ElementValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
