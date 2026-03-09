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
/// Specifies the identification attribtues of an invoice which are required by the creditor for the activation of the debtor.
/// </summary>
[IsoId("_zyspBeH5Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Invoice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditorInvoice4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the creditor allows limited presentment of the e-invoice, that is, only the e-invoice data needed for payment initiation.
    /// When absent, the element is not applicable.
    /// </summary>
    [IsoId("_zz-bYeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Limited Presentment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtdPresntmntInd")]
    #endif
    [IsoXmlTag("LtdPresntmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LimitedPresentmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LimitedPresentmentIndicator { get; init; } 
    #else
    public System.String? LimitedPresentmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous type of the identification of the debtor required by the creditor, for example  the reference number or customer number. Unique identification provided by the web bank or web payment services user, with which the creditor may identify the debtor in its system.
    /// </summary>
    [IsoId("_zz-bY-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Customer Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrIdTp")]
    #endif
    [IsoXmlTag("CstmrIdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerTypeRequest2? CustomerIdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerTypeRequest2? CustomerIdentificationType { get; init; } 
    #else
    public CustomerTypeRequest2? CustomerIdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Document format type supported to exchange the contracts.
    /// </summary>
    [IsoId("_zz-bZeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Contract Format Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctFrmtTp")]
    #endif
    [IsoXmlTag("CtrctFrmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentFormat2Choice_? ContractFormatType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentFormat2Choice_? ContractFormatType { get; init; } 
    #else
    public DocumentFormat2Choice_? ContractFormatType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the contract reference requested by the creditor which the debtor must provide in the debtor activation request  to identify the contract(s) for which the RTP is requested.
    /// </summary>
    [IsoId("_zz-bZ-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Contract Reference Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctRefTp")]
    #endif
    [IsoXmlTag("CtrctRefTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentType1Choice_? ContractReferenceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentType1Choice_? ContractReferenceType { get; init; } 
    #else
    public DocumentType1Choice_? ContractReferenceType { get; set; } 
    #endif
    
    /// <summary>
    /// Instructions provided by the seller (that is creditor or ultimate creditor) for the Request-To-Pay (RTP) recipient (that is the debtor). The instructions may include for example the time required by the creditor to take into account the activation request. The debtor agent may display the information in the customer’s own service language.
    /// </summary>
    [IsoId("_zz-baeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrInstr")]
    #endif
    [IsoXmlTag("CdtrInstr")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? CreditorInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorInstruction { get; init; } 
    #else
    public System.String? CreditorInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Creditor&apos;s service provider address to which the debtor activation has to be delivered.
    /// </summary>
    [IsoId("_zz-ba-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Activation Request Delivery Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtnReqDlvryPty")]
    #endif
    [IsoXmlTag("ActvtnReqDlvryPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; init; } 
    #else
    public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
