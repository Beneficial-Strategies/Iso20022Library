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
/// Payment wire instruction details.
/// </summary>
[IsoId("_xOUmcUlBEeK8UrXTVVBVxw")]
[DisplayName("Wire Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record WireInstructionSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a WireInstructionSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public WireInstructionSD2( System.String reqPlaceAndName,FinancialInstrumentQuantity15Choice_ reqWireQuantity,System.String reqBankName,System.String reqBankAddress,System.String reqBankCity,string reqBankCountry,System.String reqBankAttentionTo,System.String reqBankComments,System.String reqBeneficiaryAccount,System.String reqBeneficiaryAccountIdentification,System.String reqBeneficiaryAccountComments )
    {
        PlaceAndName = reqPlaceAndName;
        WireQuantity = reqWireQuantity;
        BankName = reqBankName;
        BankAddress = reqBankAddress;
        BankCity = reqBankCity;
        BankCountry = reqBankCountry;
        BankAttentionTo = reqBankAttentionTo;
        BankComments = reqBankComments;
        BeneficiaryAccount = reqBeneficiaryAccount;
        BeneficiaryAccountIdentification = reqBeneficiaryAccountIdentification;
        BeneficiaryAccountComments = reqBeneficiaryAccountComments;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_xlizoUlBEeK8UrXTVVBVxw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities concerned in this wire.
    /// </summary>
    [IsoId("_xlizpUlBEeK8UrXTVVBVxw")]
    [DisplayName("Wire Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WireQty")]
    #endif
    [IsoXmlTag("WireQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ WireQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ WireQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ WireQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ WireQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the recipient bank for the wire.
    /// </summary>
    [IsoId("_xlizr0lBEeK8UrXTVVBVxw")]
    [DisplayName("Bank Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkNm")]
    #endif
    [IsoXmlTag("BkNm")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text BankName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BankName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BankName { get; init; } 
    #else
    public System.String BankName { get; set; } 
    #endif
    
    /// <summary>
    /// Street address of the recipient bank for the wire.
    /// </summary>
    [IsoId("_xlizuUlBEeK8UrXTVVBVxw")]
    [DisplayName("Bank Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkAdr")]
    #endif
    [IsoXmlTag("BkAdr")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text BankAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BankAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BankAddress { get; init; } 
    #else
    public System.String BankAddress { get; set; } 
    #endif
    
    /// <summary>
    /// City of the recipient bank for the wire.
    /// </summary>
    [IsoId("_xlizw0lBEeK8UrXTVVBVxw")]
    [DisplayName("Bank City")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkCity")]
    #endif
    [IsoXmlTag("BkCity")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text BankCity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BankCity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BankCity { get; init; } 
    #else
    public System.String BankCity { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the recipient bank for the wire.
    /// </summary>
    [IsoId("_xlizzUlBEeK8UrXTVVBVxw")]
    [DisplayName("Bank Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkCtry")]
    #endif
    [IsoXmlTag("BkCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode BankCountry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string BankCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string BankCountry { get; init; } 
    #else
    public string BankCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Responsible person in the recipient back for the wire.
    /// </summary>
    [IsoId("_xliz10lBEeK8UrXTVVBVxw")]
    [DisplayName("Bank Attention To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkAttnTo")]
    #endif
    [IsoXmlTag("BkAttnTo")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text BankAttentionTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BankAttentionTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BankAttentionTo { get; init; } 
    #else
    public System.String BankAttentionTo { get; set; } 
    #endif
    
    /// <summary>
    /// Notes or comments for the recipient bank for the wire.
    /// </summary>
    [IsoId("_xliz4UlBEeK8UrXTVVBVxw")]
    [DisplayName("Bank Comments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkCmnts")]
    #endif
    [IsoXmlTag("BkCmnts")]
    [IsoSimpleType(IsoSimpleType.Max60Text)]
    [StringLength(maximumLength: 60 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax60Text BankComments { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BankComments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BankComments { get; init; } 
    #else
    public System.String BankComments { get; set; } 
    #endif
    
    /// <summary>
    /// Account type at the recipient bank for the wire.
    /// </summary>
    [IsoId("_xliz60lBEeK8UrXTVVBVxw")]
    [DisplayName("Beneficiary Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryAcct")]
    #endif
    [IsoXmlTag("BnfcryAcct")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text BeneficiaryAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BeneficiaryAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BeneficiaryAccount { get; init; } 
    #else
    public System.String BeneficiaryAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account identification at the recipient bank for the wire.
    /// </summary>
    [IsoId("_xliz9UlBEeK8UrXTVVBVxw")]
    [DisplayName("Beneficiary Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryAcctId")]
    #endif
    [IsoXmlTag("BnfcryAcctId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text BeneficiaryAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BeneficiaryAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BeneficiaryAccountIdentification { get; init; } 
    #else
    public System.String BeneficiaryAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Notes or comments for the beneficiary account at the recipient bank for the wire.
    /// </summary>
    [IsoId("_xliz_0lBEeK8UrXTVVBVxw")]
    [DisplayName("Beneficiary Account Comments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryAcctCmnts")]
    #endif
    [IsoXmlTag("BnfcryAcctCmnts")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text BeneficiaryAccountComments { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BeneficiaryAccountComments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BeneficiaryAccountComments { get; init; } 
    #else
    public System.String BeneficiaryAccountComments { get; set; } 
    #endif
    
    
    #nullable disable
    
}
