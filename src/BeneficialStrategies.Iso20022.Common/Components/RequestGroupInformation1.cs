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
/// Set of characteristics that unambiguously identify the global invoice financing request.
/// </summary>
[IsoId("_TiYfoNp-Ed-ak6NoX_4Aeg_1465496511")]
[DisplayName("Request Group Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestGroupInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestGroupInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestGroupInformation1( System.String reqGroupIdentification,System.DateTime reqCreationDateTime,string reqCurrency,PartyIdentificationAndAccount6 reqFinancingRequestor,FinancialInstitutionIdentification6 reqFirstAgent )
    {
        GroupIdentification = reqGroupIdentification;
        CreationDateTime = reqCreationDateTime;
        Currency = reqCurrency;
        FinancingRequestor = reqFinancingRequestor;
        FirstAgent = reqFirstAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference assigned by the financing requestor to unambiguously identify the invoice financing request message.||Usage: The financing requestor has to make sure that &apos;GroupIdentification&apos; is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_TiYfodp-Ed-ak6NoX_4Aeg_1465496537")]
    [DisplayName("Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpId")]
    #endif
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text GroupIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GroupIdentification { get; init; } 
    #else
    public System.String GroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time on which the invoice financing request was created.
    /// </summary>
    [IsoId("_TiYfotp-Ed-ak6NoX_4Aeg_1465496553")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// User identification or any user key that allows to check if the financing requestor is allowed to ask for invoice financing.||Usage: the content is not of a technical nature, but reflects the organisational structure at the requesting side.|The authorisation element can typically be used in case the financing requestor acts on behalf of one or more suppliers.
    /// </summary>
    [IsoId("_TiYfo9p-Ed-ak6NoX_4Aeg_515663679")]
    [DisplayName("Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authstn")]
    #endif
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> Authorisation { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Specifies the number of single invoice financing requests included in the bulk request message.
    /// </summary>
    [IsoId("_TiYfpNp-Ed-ak6NoX_4Aeg_1465496571")]
    [DisplayName("Number Of Invoice Requests")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfInvcReqs")]
    #endif
    [IsoXmlTag("NbOfInvcReqs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfInvoiceRequests { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfInvoiceRequests { get; init; } 
    #else
    public System.String? NumberOfInvoiceRequests { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the bulk invoice financing request. It is composed by the sum of the total amounts of all invoices included in the financing request.
    /// </summary>
    [IsoId("_TiYfpdp-Ed-ak6NoX_4Aeg_1465496613")]
    [DisplayName("Total Bulk Invoice Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlBlkInvcAmt")]
    #endif
    [IsoXmlTag("TtlBlkInvcAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalBulkInvoiceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalBulkInvoiceAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalBulkInvoiceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Reference currency of the invoice financing request.
    /// </summary>
    [IsoId("_TiYfptp-Ed-ak6NoX_4Aeg_1465496631")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the financing method related to invoice financing (eg collection mandate).
    /// </summary>
    [IsoId("_TiYfp9p-Ed-ak6NoX_4Aeg_1465496648")]
    [DisplayName("Financing Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgAgrmt")]
    #endif
    [IsoXmlTag("FincgAgrmt")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FinancingAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinancingAgreement { get; init; } 
    #else
    public System.String? FinancingAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Party that requests the invoice financing, on behalf of a creditor.
    /// </summary>
    [IsoId("_TiYfqNp-Ed-ak6NoX_4Aeg_1465497021")]
    [DisplayName("Financing Requestor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgRqstr")]
    #endif
    [IsoXmlTag("FincgRqstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount6 FinancingRequestor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount6 FinancingRequestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount6 FinancingRequestor { get; init; } 
    #else
    public PartyIdentificationAndAccount6 FinancingRequestor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that receives the request from the financing requestor and forwards it to the first agent for execution.
    /// </summary>
    [IsoId("_TiYfqdp-Ed-ak6NoX_4Aeg_1465497004")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt")]
    #endif
    [IsoXmlTag("IntrmyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of financing requestor to which an invoice financing request is addressed.
    /// </summary>
    [IsoId("_TiiQoNp-Ed-ak6NoX_4Aeg_1465496752")]
    [DisplayName("First Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstAgt")]
    #endif
    [IsoXmlTag("FrstAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification6 FirstAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification6 FirstAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification6 FirstAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification6 FirstAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agreements between financing requestor and his bank concerning conditions about the service of invoice financing, based on specific contractual schemes.
    /// </summary>
    [IsoId("_TiiQodp-Ed-ak6NoX_4Aeg_1465496695")]
    [DisplayName("Agreement Clauses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtClauses")]
    #endif
    [IsoXmlTag("AgrmtClauses")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreementClauses1? AgreementClauses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreementClauses1? AgreementClauses { get; init; } 
    #else
    public AgreementClauses1? AgreementClauses { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the financing request.
    /// </summary>
    [IsoId("_TiiQotp-Ed-ak6NoX_4Aeg_-1564243574")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation1? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation1? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation1? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
