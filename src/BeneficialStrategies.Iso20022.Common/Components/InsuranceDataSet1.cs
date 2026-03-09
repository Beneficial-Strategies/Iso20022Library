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
/// Formal document used to record a fact and used as proof of the fact that goods have been insured under an insurance policy.
/// </summary>
[IsoId("_Tm2v9tp-Ed-ak6NoX_4Aeg_888710434")]
[DisplayName("Insurance Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InsuranceDataSet1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InsuranceDataSet1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InsuranceDataSet1( DocumentIdentification1 reqDataSetIdentification,PartyIdentification26 reqIssuer,System.DateOnly reqIssueDate,System.String reqInsuranceDocumentIdentification,CurrencyAndAmount reqInsuredAmount,PartyIdentification29Choice_ reqAssured,PostalAddress5 reqClaimsPayableAt )
    {
        DataSetIdentification = reqDataSetIdentification;
        Issuer = reqIssuer;
        IssueDate = reqIssueDate;
        InsuranceDocumentIdentification = reqInsuranceDocumentIdentification;
        InsuredAmount = reqInsuredAmount;
        Assured = reqAssured;
        ClaimsPayableAt = reqClaimsPayableAt;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the insurancedata set.
    /// </summary>
    [IsoId("_Tm2v99p-Ed-ak6NoX_4Aeg_-1099246738")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification1 DataSetIdentification { get; init; } 
    #else
    public DocumentIdentification1 DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the certificate, typically the insurance company or its agent.
    /// </summary>
    [IsoId("_Tm2v-Np-Ed-ak6NoX_4Aeg_1216560686")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Issuer { get; init; } 
    #else
    public PartyIdentification26 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_Tm2v-dp-Ed-ak6NoX_4Aeg_1545335745")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssueDate { get; init; } 
    #else
    public System.DateOnly IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date upon which cover under an insurance policy becomes effective.
    /// </summary>
    [IsoId("_Tm2v-tp-Ed-ak6NoX_4Aeg_1571192429")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EffectiveDate { get; init; } 
    #else
    public System.DateOnly? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the insurance certificate was issued.
    /// </summary>
    [IsoId("_Tm2v-9p-Ed-ak6NoX_4Aeg_1690329886")]
    [DisplayName("Place Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfIsse")]
    #endif
    [IsoXmlTag("PlcOfIsse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress5? PlaceOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress5? PlaceOfIssue { get; init; } 
    #else
    public PostalAddress5? PlaceOfIssue { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_Tm2v_Np-Ed-ak6NoX_4Aeg_1786375668")]
    [DisplayName("Insurance Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncDocId")]
    #endif
    [IsoXmlTag("InsrncDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InsuranceDocumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InsuranceDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InsuranceDocumentIdentification { get; init; } 
    #else
    public System.String InsuranceDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Transport information relative to the goods that are insured under the insurance policy.
    /// </summary>
    [IsoId("_Tm_54Np-Ed-ak6NoX_4Aeg_-1469580210")]
    [DisplayName("Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trnsprt")]
    #endif
    [IsoXmlTag("Trnsprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SingleTransport3? Transport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SingleTransport3? Transport { get; init; } 
    #else
    public SingleTransport3? Transport { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the goods as insured under the insurance policy.
    /// </summary>
    [IsoId("_Tm_54dp-Ed-ak6NoX_4Aeg_-397424452")]
    [DisplayName("Insured Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrdAmt")]
    #endif
    [IsoXmlTag("InsrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount InsuredAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount InsuredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount InsuredAmount { get; init; } 
    #else
    public CurrencyAndAmount InsuredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_Tm_54tp-Ed-ak6NoX_4Aeg_-88042726")]
    [DisplayName("Insured Goods Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrdGoodsDesc")]
    #endif
    [IsoXmlTag("InsrdGoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? InsuredGoodsDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuredGoodsDescription { get; init; } 
    #else
    public System.String? InsuredGoodsDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the conditions and exclusion clauses under which insurance is granted.
    /// </summary>
    [IsoId("_Tm_549p-Ed-ak6NoX_4Aeg_515013339")]
    [DisplayName("Insurance Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncConds")]
    #endif
    [IsoXmlTag("InsrncConds")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InsuranceConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceConditions { get; init; } 
    #else
    public System.String? InsuranceConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Standard insurance clauses defined by the Institute of London Underwriters (or the American Institute of marine Underwriters).
    /// </summary>
    [IsoId("_Tm_55Np-Ed-ak6NoX_4Aeg_812386949")]
    [DisplayName("Insurance Clauses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncClauses")]
    #endif
    [IsoXmlTag("InsrncClauses")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InsuranceClauses1Code? InsuranceClauses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InsuranceClauses1Code? InsuranceClauses { get; init; } 
    #else
    public InsuranceClauses1Code? InsuranceClauses { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is covered under the assurance policy.
    /// </summary>
    [IsoId("_Tm_55dp-Ed-ak6NoX_4Aeg_976774092")]
    [DisplayName("Assured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assrd")]
    #endif
    [IsoXmlTag("Assrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification29Choice_ Assured { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification29Choice_ Assured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification29Choice_ Assured { get; init; } 
    #else
    public PartyIdentification29Choice_ Assured { get; set; } 
    #endif
    
    /// <summary>
    /// Place where claims under the insurance policy will be paid.
    /// </summary>
    [IsoId("_Tm_55tp-Ed-ak6NoX_4Aeg_1330485176")]
    [DisplayName("Claims Payable At")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClmsPyblAt")]
    #endif
    [IsoXmlTag("ClmsPyblAt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress5 ClaimsPayableAt { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PostalAddress5 ClaimsPayableAt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress5 ClaimsPayableAt { get; init; } 
    #else
    public PostalAddress5 ClaimsPayableAt { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which claims, if valid, will be paid.
    /// </summary>
    [IsoId("_Tm_559p-Ed-ak6NoX_4Aeg_1343411929")]
    [DisplayName("Claims Payable In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClmsPyblIn")]
    #endif
    [IsoXmlTag("ClmsPyblIn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? ClaimsPayableIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ClaimsPayableIn { get; init; } 
    #else
    public string? ClaimsPayableIn { get; set; } 
    #endif
    
    
    #nullable disable
    
}
