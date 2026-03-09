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
/// Variables related to derivatives that are used to group derivatives together into positions for position sets.
/// </summary>
[IsoId("_hOjrQcguEeuGrNSsxk3B0A")]
[DisplayName("Position Set Dimensions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetDimensions15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information describing the reporting counterparty.
    /// </summary>
    [IsoId("_hP-nk8guEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; init; } 
    #else
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to other counterparties and related fields.
    /// </summary>
    [IsoId("_hP-nlcguEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? OtherCounterparty { get; init; } 
    #else
    public OrganisationIdentification15Choice_? OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_hP-nl8guEeuGrNSsxk3B0A")]
    [DisplayName("Collateral Portfolio Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflId")]
    #endif
    [IsoXmlTag("CollPrtflId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? CollateralPortfolioIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralPortfolioIdentification { get; init; } 
    #else
    public System.String? CollateralPortfolioIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to identify whether the reported Securities Financing Transaction position contains abnormal values.
    /// </summary>
    [IsoId("_hP-nmcguEeuGrNSsxk3B0A")]
    [DisplayName("Outliers Included")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OtlrsIncl")]
    #endif
    [IsoXmlTag("OtlrsIncl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OutliersIncluded { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OutliersIncluded { get; init; } 
    #else
    public System.String? OutliersIncluded { get; set; } 
    #endif
    
    
    #nullable disable
    
}
