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
/// Structured information related to the invoice to be financed.
/// </summary>
[IsoId("_ThfHx9p-Ed-ak6NoX_4Aeg_415673992")]
[DisplayName("Referred Document Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReferredDocumentInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_ThfHyNp-Ed-ak6NoX_4Aeg_1244134096")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredDocumentType1? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredDocumentType1? Type { get; init; } 
    #else
    public ReferredDocumentType1? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification number of the referred document.
    /// </summary>
    [IsoId("_Tho4wNp-Ed-ak6NoX_4Aeg_785144500")]
    [DisplayName("Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocNb")]
    #endif
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DocumentNumber { get; init; } 
    #else
    public System.String? DocumentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date associated with the referred document, eg, date of issue.
    /// </summary>
    [IsoId("_Tho4wdp-Ed-ak6NoX_4Aeg_1357727086")]
    [DisplayName("Related Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDt")]
    #endif
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RelatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RelatedDate { get; init; } 
    #else
    public System.DateOnly? RelatedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money and currency of a document referred to invoice to be financed.
    /// </summary>
    [IsoId("_Tho4wtp-Ed-ak6NoX_4Aeg_1784392308")]
    [DisplayName("Document Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocAmt")]
    #endif
    [IsoXmlTag("DocAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? DocumentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? DocumentAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? DocumentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
