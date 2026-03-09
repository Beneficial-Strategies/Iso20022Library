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
/// Non-protected sensitive data associated with the card or payment token performing the transaction.
/// </summary>
[IsoId("_0VngAVTtEeeeIYOiLZFQGg")]
[DisplayName("Card Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardData1( System.String reqPAN )
    {
        PAN = reqPAN;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// ISO 8583 bit 2
    /// </summary>
    [IsoId("_0hEiEVTtEeeeIYOiLZFQGg")]
    [DisplayName("PAN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PAN")]
    #endif
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax19NumericText PAN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PAN { get; init; } 
    #else
    public System.String PAN { get; set; } 
    #endif
    
    /// <summary>
    /// To indicate whether the PAN is using ProtectedData for encryption or not.
    /// False: The PAN is used in plain text 
    /// True: The PAN is encrypted by using ProtectedData
    /// Default: False
    /// </summary>
    [IsoId("_HYYGQBWAEeiTbY4xN42WAw")]
    [DisplayName("Protected PAN Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdPANInd")]
    #endif
    [IsoXmlTag("PrtctdPANInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ProtectedPANIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectedPANIndicator { get; init; } 
    #else
    public System.String? ProtectedPANIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// ISO 8583 bit 23
    /// </summary>
    [IsoId("_0hEiE1TtEeeeIYOiLZFQGg")]
    [DisplayName("Card Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSeqNb")]
    #endif
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardSequenceNumber { get; init; } 
    #else
    public System.String? CardSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date as from which the card can be used, expressed in one of the following formats: YYYY-MM-DD, YYYY-MM, YY-MM-DD.
    /// ISO 8583:93 &amp; ISO 8583:2003-1 bit 13
    /// </summary>
    [IsoId("_0hEiFVTtEeeeIYOiLZFQGg")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EffectiveDate { get; init; } 
    #else
    public System.String? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Expiry date of the card or payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_0hEiF1TtEeeeIYOiLZFQGg")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExpiryDate { get; init; } 
    #else
    public System.String? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Service attached to the card as defined in ISO 7813.
    /// ISO 8583 bit 40.
    /// </summary>
    [IsoId("_0hEiGVTtEeeeIYOiLZFQGg")]
    [DisplayName("Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCd")]
    #endif
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? ServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceCode { get; init; } 
    #else
    public System.String? ServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// ISO track 1 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format conforms to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 45
    /// </summary>
    [IsoId("_0hEiG1TtEeeeIYOiLZFQGg")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck1")]
    #endif
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max76Text)]
    [StringLength(maximumLength: 76 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax76Text? Track1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track1 { get; init; } 
    #else
    public System.String? Track1 { get; set; } 
    #endif
    
    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format  conforms to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 35
    /// </summary>
    [IsoId("_0hEiHVTtEeeeIYOiLZFQGg")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck2")]
    #endif
    [IsoXmlTag("Trck2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Track2Data1Choice_? Track2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Track2Data1Choice_? Track2 { get; init; } 
    #else
    public Track2Data1Choice_? Track2 { get; set; } 
    #endif
    
    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content conforms to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 36
    /// </summary>
    [IsoId("_0hEiH1TtEeeeIYOiLZFQGg")]
    [DisplayName("Track")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trck3")]
    #endif
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max104Text)]
    [StringLength(maximumLength: 104 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax104Text? Track3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Track3 { get; init; } 
    #else
    public System.String? Track3 { get; set; } 
    #endif
    
    /// <summary>
    /// Unique non-financial reference assigned to a given PAN. May be used to link the transaction activity to that PAN.
    /// ISO 8583:87 bit 56 (TLV tag 01/dataset 71)
    /// ISO 8583:93 bit 112 (TLV tag 01/dataset 71)
    /// ISO 8583:2003 bit 51 (TLV tag 01/dataset 71)
    /// </summary>
    [IsoId("_0hEiIVTtEeeeIYOiLZFQGg")]
    [DisplayName("Payment Account Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcctRef")]
    #endif
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PaymentAccountReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentAccountReference { get; init; } 
    #else
    public System.String? PaymentAccountReference { get; set; } 
    #endif
    
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// ISO 8583 bit 20
    /// </summary>
    [IsoId("_wOcxUALUEemY3fGHca_J_g")]
    [DisplayName("Card Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardCtryCd")]
    #endif
    [IsoXmlTag("CardCtryCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCountryCode? CardCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CardCountryCode { get; init; } 
    #else
    public string? CardCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_wOcxUQLUEemY3fGHca_J_g")]
    [DisplayName("Card Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPdctTp")]
    #endif
    [IsoXmlTag("CardPdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductType { get; init; } 
    #else
    public System.String? CardProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Subtype of card product.
    /// </summary>
    [IsoId("_wOcxUgLUEemY3fGHca_J_g")]
    [DisplayName("Card Product Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPdctSubTp")]
    #endif
    [IsoXmlTag("CardPdctSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductSubType { get; init; } 
    #else
    public System.String? CardProductSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the card portfolio. 
    /// </summary>
    [IsoId("_KOXaAJaQEemfCcEf5rVTyg")]
    [DisplayName("Card Portfolio Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPrtflIdr")]
    #endif
    [IsoXmlTag("CardPrtflIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardPortfolioIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardPortfolioIdentifier { get; init; } 
    #else
    public System.String? CardPortfolioIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_0hEiN1TtEeeeIYOiLZFQGg")]
    [DisplayName("Additional Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCardData")]
    #endif
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalCardData { get; init; } 
    #else
    public System.String? AdditionalCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
