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
/// Set of information related to the cancellation request, such as actors involved and identification of the original multiple invoice financing request to which the cancellation request is referring.
/// </summary>
[IsoId("_TiiQo9p-Ed-ak6NoX_4Aeg_1653900933")]
[DisplayName("Cancellation Request Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancellationRequestInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancellationRequestInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancellationRequestInformation1( System.String reqOriginalGroupIdentification,System.DateTime reqOriginalCreationDateTime,System.String reqCancellationReason )
    {
        OriginalGroupIdentification = reqOriginalGroupIdentification;
        OriginalCreationDateTime = reqOriginalCreationDateTime;
        CancellationReason = reqCancellationReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the original financing request message as assigned by the original sending party.
    /// </summary>
    [IsoId("_TiiQpNp-Ed-ak6NoX_4Aeg_1653900935")]
    [DisplayName("Original Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpId")]
    #endif
    [IsoXmlTag("OrgnlGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalGroupIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalGroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalGroupIdentification { get; init; } 
    #else
    public System.String OriginalGroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the original financing request message was created.
    /// </summary>
    [IsoId("_TiiQpdp-Ed-ak6NoX_4Aeg_1653900951")]
    [DisplayName("Original Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCreDtTm")]
    #endif
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime OriginalCreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime OriginalCreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime OriginalCreationDateTime { get; init; } 
    #else
    public System.DateTime OriginalCreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of single invoice financing requests included in the original financing request message.
    /// </summary>
    [IsoId("_TiiQptp-Ed-ak6NoX_4Aeg_1653900968")]
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
    /// Total amount of the bulk invoice financing request. It is composed by the sum of the total amounts of all invoices included in the original financing request message.
    /// </summary>
    [IsoId("_TiiQp9p-Ed-ak6NoX_4Aeg_1653900986")]
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
    /// Further details on the cancellation request information, in an uncoded form.
    /// </summary>
    [IsoId("_TiiQqNp-Ed-ak6NoX_4Aeg_-96892245")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax105Text CancellationReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CancellationReason { get; init; } 
    #else
    public System.String CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Party that requests the cancellation of a financing request previously sent.
    /// </summary>
    [IsoId("_TirakNp-Ed-ak6NoX_4Aeg_-606230601")]
    [DisplayName("Financing Requestor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgRqstr")]
    #endif
    [IsoXmlTag("FincgRqstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount6? FinancingRequestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount6? FinancingRequestor { get; init; } 
    #else
    public PartyIdentificationAndAccount6? FinancingRequestor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that receives the request from the financing requestor and forwards it to the first agent for execution.
    /// </summary>
    [IsoId("_Tirakdp-Ed-ak6NoX_4Aeg_-604384907")]
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
    /// Financial institution of financing requestor to which an invoice financing cancellation request is addressed.
    /// </summary>
    [IsoId("_Tiraktp-Ed-ak6NoX_4Aeg_-603459399")]
    [DisplayName("First Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstAgt")]
    #endif
    [IsoXmlTag("FrstAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification6? FirstAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification6? FirstAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification6? FirstAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
