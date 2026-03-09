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
[IsoId("_F6dn8cguEeuGrNSsxk3B0A")]
[DisplayName("Position Set Dimensions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetDimensions14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties.
    /// </summary>
    [IsoId("_F8SM48guEeuGrNSsxk3B0A")]
    [DisplayName("Counterparty Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyData")]
    #endif
    [IsoXmlTag("CtrPtyData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyData86? CounterpartyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData86? CounterpartyData { get; init; } 
    #else
    public CounterpartyData86? CounterpartyData { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_F8SM5cguEeuGrNSsxk3B0A")]
    [DisplayName("Loan Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnData")]
    #endif
    [IsoXmlTag("LnData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoanData134? LoanData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoanData134? LoanData { get; init; } 
    #else
    public LoanData134? LoanData { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [IsoId("_F8SM58guEeuGrNSsxk3B0A")]
    [DisplayName("Collateral Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollData")]
    #endif
    [IsoXmlTag("CollData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralData33? CollateralData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralData33? CollateralData { get; init; } 
    #else
    public CollateralData33? CollateralData { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to identify whether the reported Securities Financing Transaction position contains abnormal values.
    /// </summary>
    [IsoId("_F8SM6cguEeuGrNSsxk3B0A")]
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
