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
/// Provides the details of each individual invoice tax report transaction.
/// </summary>
[IsoId("_8pkzYU53Eeaine-lsNAGsA")]
[DisplayName("Invoice Tax Report Transaction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceTaxReportTransactionStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvoiceTaxReportTransactionStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceTaxReportTransactionStatus1( System.String reqTaxReportIdentification,TaxReportingStatus2Code reqStatus )
    {
        TaxReportIdentification = reqTaxReportIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Report identification, for example invoice number or report number from point of sales system.
    /// </summary>
    [IsoId("_8xqYYU53Eeaine-lsNAGsA")]
    [DisplayName("Tax Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRptId")]
    #endif
    [IsoXmlTag("TaxRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TaxReportIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TaxReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TaxReportIdentification { get; init; } 
    #else
    public System.String TaxReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines status of the reported transaction.
    /// </summary>
    [IsoId("_8xqYZ053Eeaine-lsNAGsA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxReportingStatus2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxReportingStatus2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReportingStatus2Code Status { get; init; } 
    #else
    public TaxReportingStatus2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_8xqYaU53Eeaine-lsNAGsA")]
    [DisplayName("Validation Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnRule")]
    #endif
    [IsoXmlTag("VldtnRule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #else
    public GenericValidationRuleIdentification1? ValidationRule { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_8xqYa053Eeaine-lsNAGsA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
