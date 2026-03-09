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
/// Provides detailed information about the travel package, excluding specific itinerary data.
/// </summary>
[IsoId("_VWwMQ_PYEeihCvvpsmGI2w")]
[DisplayName("Travel Agency Package")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TravelAgencyPackage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reservation number or identifier. 
    /// </summary>
    [IsoId("_VWwMTPPYEeihCvvpsmGI2w")]
    [DisplayName("Reservation Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsvatnNb")]
    #endif
    [IsoXmlTag("RsvatnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReservationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReservationNumber { get; init; } 
    #else
    public System.String? ReservationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of travel offering provided by the travel agency or partner.
    /// </summary>
    [IsoId("_VW4vFPPYEeihCvvpsmGI2w")]
    [DisplayName("Travel Package Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrvlPackgTp")]
    #endif
    [IsoXmlTag("TrvlPackgTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TravelPackageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TravelPackageType { get; init; } 
    #else
    public System.String? TravelPackageType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of people included in the travel arrangements. 
    /// </summary>
    [IsoId("_VW4vFvPYEeihCvvpsmGI2w")]
    [DisplayName("Number In Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbInPty")]
    #endif
    [IsoXmlTag("NbInPty")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? NumberInParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberInParty { get; init; } 
    #else
    public System.String? NumberInParty { get; set; } 
    #endif
    
    /// <summary>
    /// Contains Customer Reference Values provided for this transaction and used for various reference processing at the customer site. These values represent information most prevalently provided by travel agencies for transactions booked against a lodged account or central travel account.
    /// </summary>
    [IsoId("_VWwMRfPYEeihCvvpsmGI2w")]
    [DisplayName("Customer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRef")]
    #endif
    [IsoXmlTag("CstmrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerReference1? CustomerReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerReference1? CustomerReference { get; init; } 
    #else
    public CustomerReference1? CustomerReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the source of enhanced data that is matched to the transaction.
    /// </summary>
    [IsoId("_VWwMS_PYEeihCvvpsmGI2w")]
    [DisplayName("Data Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSrc")]
    #endif
    [IsoXmlTag("DataSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DataSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DataSource { get; init; } 
    #else
    public System.String? DataSource { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a customer invoice number for a rail sale to a corporate account.
    /// </summary>
    [IsoId("_VW4vF_PYEeihCvvpsmGI2w")]
    [DisplayName("Delivery Order Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryOrdrNb")]
    #endif
    [IsoXmlTag("DlvryOrdrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DeliveryOrderNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryOrderNumber { get; init; } 
    #else
    public System.String? DeliveryOrderNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a slip number from the credit card slip.
    /// </summary>
    [IsoId("_VWwMRvPYEeihCvvpsmGI2w")]
    [DisplayName("Credit Card Slip Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtCardSlipNb")]
    #endif
    [IsoXmlTag("CdtCardSlipNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CreditCardSlipNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditCardSlipNumber { get; init; } 
    #else
    public System.String? CreditCardSlipNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_VW4vEPPYEeihCvvpsmGI2w")]
    [DisplayName("Insurance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncInd")]
    #endif
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceIndicator { get; init; } 
    #else
    public System.String? InsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_VWwMTfPYEeihCvvpsmGI2w")]
    [DisplayName("Insurance Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncAmt")]
    #endif
    [IsoXmlTag("InsrncAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Travel agency fee amount.
    /// </summary>
    [IsoId("_VW4vEvPYEeihCvvpsmGI2w")]
    [DisplayName("Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fee")]
    #endif
    [IsoXmlTag("Fee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Fee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Fee { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Fee { get; set; } 
    #endif
    
    
    #nullable disable
    
}
