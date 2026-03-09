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
/// Contains transaction details.
/// </summary>
[IsoId("_vB-boTNJEeylu6lH-gut-A")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction144
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction144 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction144( AdministrativeType1Code reqAdministrativeType,TransactionIdentification12 reqTransactionIdentification )
    {
        AdministrativeType = reqAdministrativeType;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code that identifies an administrative type.
    /// </summary>
    [IsoId("_EakJ0DNKEeylu6lH-gut-A")]
    [DisplayName("Administrative Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdmstvTp")]
    #endif
    [IsoXmlTag("AdmstvTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdministrativeType1Code AdministrativeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdministrativeType1Code AdministrativeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdministrativeType1Code AdministrativeType { get; init; } 
    #else
    public AdministrativeType1Code AdministrativeType { get; set; } 
    #endif
    
    /// <summary>
    /// Other administrative type defined at private or national level.
    /// </summary>
    [IsoId("_gcgVIDNLEeylu6lH-gut-A")]
    [DisplayName("Other Administrative Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAdmstvTp")]
    #endif
    [IsoXmlTag("OthrAdmstvTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherAdministrativeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherAdministrativeType { get; init; } 
    #else
    public System.String? OtherAdministrativeType { get; set; } 
    #endif
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_vIt83zNJEeylu6lH-gut-A")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? MessageReason { get; init; } 
    #else
    public string? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_vIt87TNJEeylu6lH-gut-A")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_vIt88TNJEeylu6lH-gut-A")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalService2? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalService2? AdditionalService { get; init; } 
    #else
    public AdditionalService2? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_vIt88zNJEeylu6lH-gut-A")]
    [DisplayName("Associated Data Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDataInd")]
    #endif
    [IsoXmlTag("AssoctdDataInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AssociatedDataIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedDataIndicator { get; init; } 
    #else
    public System.String? AssociatedDataIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_vIt89TNJEeylu6lH-gut-A")]
    [DisplayName("Associated Data Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDataRef")]
    #endif
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AssociatedDataReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedDataReference { get; init; } 
    #else
    public System.String? AssociatedDataReference { get; set; } 
    #endif
    
    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_vIt89zNJEeylu6lH-gut-A")]
    [DisplayName("Associated Data Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDataDstn")]
    #endif
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssociatedDataDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedDataDestination { get; init; } 
    #else
    public System.String? AssociatedDataDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_vIt8-TNJEeylu6lH-gut-A")]
    [DisplayName("Special Programme Qualification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclPrgrmmQlfctn")]
    #endif
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #else
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_vIt8-zNJEeylu6lH-gut-A")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification12 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification12 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains generic text message.
    /// </summary>
    [IsoId("_8Q3z8DNLEeylu6lH-gut-A")]
    [DisplayName("Text Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxtMsg")]
    #endif
    [IsoXmlTag("TxtMsg")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20KText? TextMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TextMessage { get; init; } 
    #else
    public System.String? TextMessage { get; set; } 
    #endif
    
    /// <summary>
    /// Additional Information in local language.
    /// </summary>
    [IsoId("_NCW0IDNMEeylu6lH-gut-A")]
    [DisplayName("Local Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclData")]
    #endif
    [IsoXmlTag("LclData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalData9? LocalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalData9? LocalData { get; init; } 
    #else
    public LocalData9? LocalData { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// ISO 8583:87/93 bit 104
    /// ISO 8583:2003 bit 104-71
    /// </summary>
    [IsoId("_vIt9ITNJEeylu6lH-gut-A")]
    [DisplayName("Transaction Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDesc")]
    #endif
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? TransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionDescription { get; init; } 
    #else
    public System.String? TransactionDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_vIt9IzNJEeylu6lH-gut-A")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData2? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData2? AdditionalData { get; init; } 
    #else
    public AdditionalData2? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
