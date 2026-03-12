// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request to open an account.
/// Usage
/// This message should only be used for initiating the account opening process.
/// It could be sent together with other related documents.
/// </summary>
[Description(@"Scope|The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request to open an account.|Usage|This message should only be used for initiating the account opening process.|It could be sent together with other related documents.")]
[IsoId("_uso6-NE9Ed-BzquC8wXy7w_1165338755")]
[DisplayName("Account Opening Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountOpeningRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountOpeningRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountOpeningRequestV01( References4 reqReferences,CustomerAccount1 reqAccount,BranchAndFinancialInstitutionIdentification4 reqAccountServicerIdentification,Organisation7 reqOrganisation )
    {
        References = reqReferences;
        Account = reqAccount;
        AccountServicerIdentification = reqAccountServicerIdentification;
        Organisation = reqOrganisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_uso6-dE9Ed-BzquC8wXy7w_1140430712")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References4 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References4 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References4 References { get; init; } 
    #else
    public References4 References { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_usyr8NE9Ed-BzquC8wXy7w_-470749404")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustomerAccount1 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CustomerAccount1 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerAccount1 Account { get; init; } 
    #else
    public CustomerAccount1 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_usyr8dE9Ed-BzquC8wXy7w_936116709")]
    [DisplayName("Contract Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctDts")]
    #endif
    [IsoXmlTag("CtrctDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountContract2? ContractDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountContract2? ContractDates { get; init; } 
    #else
    public AccountContract2? ContractDates { get; set; } 
    #endif
    
    /// <summary>
    /// Account contract established between the organisation or the Group to which the organisation belongs, and the account Servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_usyr8tE9Ed-BzquC8wXy7w_-1053745104")]
    [DisplayName("Underlying Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygMstrAgrmt")]
    #endif
    [IsoXmlTag("UndrlygMstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    #else
    public ContractDocument1? UnderlyingMasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_usyr89E9Ed-BzquC8wXy7w_-452903170")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_usyr9NE9Ed-BzquC8wXy7w_-684862622")]
    [DisplayName("Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Org")]
    #endif
    [IsoXmlTag("Org")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Organisation7 Organisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Organisation7 Organisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation7 Organisation { get; init; } 
    #else
    public Organisation7 Organisation { get; set; } 
    #endif
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_usyr9dE9Ed-BzquC8wXy7w_1854082685")]
    [DisplayName("Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mndt")]
    #endif
    [IsoXmlTag("Mndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OperationMandate1? Mandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OperationMandate1? Mandate { get; init; } 
    #else
    public OperationMandate1? Mandate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_usyr9tE9Ed-BzquC8wXy7w_-1721826698")]
    [DisplayName("Reference Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefAcct")]
    #endif
    [IsoXmlTag("RefAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? ReferenceAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? ReferenceAccount { get; init; } 
    #else
    public CashAccount16? ReferenceAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_usyr99E9Ed-BzquC8wXy7w_1390915325")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature1? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature1? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature1? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AccountOpeningRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningRequestV01.

