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
/// Document that a user must file with an authorized servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_w9E7MbGIEeuSTr8k0UEM8A")]
[DisplayName("Contract Registration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractRegistration6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractRegistration6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractRegistration6( System.String reqContractRegistrationOpeningIdentification,Priority2Code reqPriority,UnderlyingContract3Choice_ reqContract )
    {
        ContractRegistrationOpeningIdentification = reqContractRegistrationOpeningIdentification;
        Priority = reqPriority;
        Contract = reqContract;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract opening.
    /// </summary>
    [IsoId("_w-U4YbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Registration Opening Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctRegnOpngId")]
    #endif
    [IsoXmlTag("CtrctRegnOpngId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ContractRegistrationOpeningIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ContractRegistrationOpeningIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ContractRegistrationOpeningIdentification { get; init; } 
    #else
    public System.String ContractRegistrationOpeningIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Priority requested for the opening of the registered contract.
    /// </summary>
    [IsoId("_w-U4abGIEeuSTr8k0UEM8A")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Priority2Code Priority { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Priority2Code Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority2Code Priority { get; init; } 
    #else
    public Priority2Code Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    [IsoId("_w-U4a7GIEeuSTr8k0UEM8A")]
    [DisplayName("Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrct")]
    #endif
    [IsoXmlTag("Ctrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingContract3Choice_ Contract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingContract3Choice_ Contract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingContract3Choice_ Contract { get; init; } 
    #else
    public UnderlyingContract3Choice_ Contract { get; set; } 
    #endif
    
    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_w-U4bbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctBal")]
    #endif
    [IsoXmlTag("CtrctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractBalance1? ContractBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractBalance1? ContractBalance { get; init; } 
    #else
    public ContractBalance1? ContractBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    [IsoId("_w-U4b7GIEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchdlTp")]
    #endif
    [IsoXmlTag("PmtSchdlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; } 
    #else
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of a previous contract registration.
    /// </summary>
    [IsoId("_w-U4cbGIEeuSTr8k0UEM8A")]
    [DisplayName("Previous Registration Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRegnId")]
    #endif
    [IsoXmlTag("PrvsRegnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? PreviousRegistrationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? PreviousRegistrationIdentification { get; init; } 
    #else
    public DocumentIdentification22? PreviousRegistrationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the registered contract opening.
    /// </summary>
    [IsoId("_w-U4c7GIEeuSTr8k0UEM8A")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the contract registration request.
    /// </summary>
    [IsoId("_w-U4dbGIEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation5? Attachment { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_w-U4d7GIEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
