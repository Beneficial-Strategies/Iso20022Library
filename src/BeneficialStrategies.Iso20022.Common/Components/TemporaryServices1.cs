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
/// Information regarding the billing for services rendered on a temporary or contract basis. The component provides information such as the employee job performed, timekeeping, and billing rates.
/// </summary>
[IsoId("_QbcTNPfSEei89sMSHxl1ew")]
[DisplayName("Temporary Services")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TemporaryServices1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the details of the contracting company that has requested temporary services. 
    /// </summary>
    [IsoId("_QbcTOffSEei89sMSHxl1ew")]
    [DisplayName("Contracting Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctgCpny")]
    #endif
    [IsoXmlTag("CtrctgCpny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryServicesCompany1? ContractingCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryServicesCompany1? ContractingCompany { get; init; } 
    #else
    public TemporaryServicesCompany1? ContractingCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Contains information about the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_QbcTOvfSEei89sMSHxl1ew")]
    [DisplayName("Temporary Employee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TempMplyee")]
    #endif
    [IsoXmlTag("TempMplyee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification210? TemporaryEmployee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification210? TemporaryEmployee { get; init; } 
    #else
    public PartyIdentification210? TemporaryEmployee { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the job or task of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_QbcTNvfSEei89sMSHxl1ew")]
    [DisplayName("Job")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Job")]
    #endif
    [IsoXmlTag("Job")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryServicesJob1? Job { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryServicesJob1? Job { get; init; } 
    #else
    public TemporaryServicesJob1? Job { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the fee for the individual working in a temporary capacity is a flat
    /// rate.
    /// </summary>
    [IsoId("_QbcTN_fSEei89sMSHxl1ew")]
    [DisplayName("Flat Rate Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlatRateInd")]
    #endif
    [IsoXmlTag("FlatRateInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? FlatRateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FlatRateIndicator { get; init; } 
    #else
    public System.String? FlatRateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the discount amount. 
    /// </summary>
    [IsoId("_e6IJUPfdEei89sMSHxl1ew")]
    [DisplayName("Discount Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntAmt")]
    #endif
    [IsoXmlTag("DscntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? DiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_QbcTNffSEei89sMSHxl1ew")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the labour performed and associated duration and billing rate. 
    /// </summary>
    [IsoId("_ns07wPfiEei89sMSHxl1ew")]
    [DisplayName("Labor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Labr")]
    #endif
    [IsoXmlTag("Labr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryServicesLabor1? Labor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryServicesLabor1? Labor { get; init; } 
    #else
    public TemporaryServicesLabor1? Labor { get; set; } 
    #endif
    
    /// <summary>
    /// Contains miscellaneous expense details.
    /// </summary>
    [IsoId("_bvgYsPfjEei89sMSHxl1ew")]
    [DisplayName("Miscellaneous Expenses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MiscExpnss")]
    #endif
    [IsoXmlTag("MiscExpnss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount13? MiscellaneousExpenses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount13? MiscellaneousExpenses { get; init; } 
    #else
    public Amount13? MiscellaneousExpenses { get; set; } 
    #endif
    
    /// <summary>
    /// Subtotal amount exclusive of tax.
    /// </summary>
    [IsoId("_nG9ZIPfjEei89sMSHxl1ew")]
    [DisplayName("Subtotal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbttlAmt")]
    #endif
    [IsoXmlTag("SbttlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? SubtotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? SubtotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? SubtotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount of taxes assessed for temporary services.
    /// </summary>
    [IsoId("_1iAGYPfjEei89sMSHxl1ew")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax33? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax33? Tax { get; init; } 
    #else
    public Tax33? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Additional user-defined data pertaining to the temporary services. 
    /// </summary>
    [IsoId("_QbcTOPfSEei89sMSHxl1ew")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
