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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, eg, a (new) plan manager sends the RequestForPEPorISAOrPortfolioInformation message to the executing party, eg, a (old) plan manager, on behalf of the initiating party, eg, an investor (client), to request information about financial instruments held on behalf of the client.
/// Usage
/// The RequestForPEPOrISAOrPortfolioInformation message is used to request information about one or more PEP or ISA or portfolio products held in a client&apos;s account for which it intends to instruct a transfer at a later time.
/// </summary>
[Description(@"Scope|An instructing party, eg, a (new) plan manager sends the RequestForPEPorISAOrPortfolioInformation message to the executing party, eg, a (old) plan manager, on behalf of the initiating party, eg, an investor (client), to request information about financial instruments held on behalf of the client.|Usage|The RequestForPEPOrISAOrPortfolioInformation message is used to request information about one or more PEP or ISA or portfolio products held in a client's account for which it intends to instruct a transfer at a later time.")]
[IsoId("_nGJAc9E5Ed-BzquC8wXy7w_2026218979")]
[DisplayName("Request For PEP Or ISA Or Portfolio Information V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestForPEPOrISAOrPortfolioInformationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForPEPOrISAOrPrtflInfV01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01";
    
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
    /// Constructs a RequestForPEPOrISAOrPortfolioInformationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestForPEPOrISAOrPortfolioInformationV01( MessageIdentification1 reqMessageReference,Account5 reqClientAccount,PartyIdentification2Choice_ reqNewPlanManager,PEPISATransfer5 reqProductTransfer )
    {
        MessageReference = reqMessageReference;
        ClientAccount = reqClientAccount;
        NewPlanManager = reqNewPlanManager;
        ProductTransfer = reqProductTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_nGJAdNE5Ed-BzquC8wXy7w_-903781955")]
    [DisplayName("Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRef")]
    #endif
    [IsoXmlTag("MsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageReference { get; init; } 
    #else
    public MessageIdentification1 MessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_nGJAddE5Ed-BzquC8wXy7w_-444791972")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PoolReference { get; init; } 
    #else
    public AdditionalReference3? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_nGJAdtE5Ed-BzquC8wXy7w_-117865583")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_nGJAd9E5Ed-BzquC8wXy7w_-19048277")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? RelatedReference { get; init; } 
    #else
    public AdditionalReference3? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_nGJAeNE5Ed-BzquC8wXy7w_-439253534")]
    [DisplayName("Primary Individual Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryIndvInvstr")]
    #endif
    [IsoXmlTag("PmryIndvInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? PrimaryIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_nGJAedE5Ed-BzquC8wXy7w_-280406209")]
    [DisplayName("Secondary Individual Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryIndvInvstr")]
    #endif
    [IsoXmlTag("ScndryIndvInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? SecondaryIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_nGSxcNE5Ed-BzquC8wXy7w_28973546")]
    [DisplayName("Other Individual Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrIndvInvstr")]
    #endif
    [IsoXmlTag("OthrIndvInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? OtherIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_nGSxcdE5Ed-BzquC8wXy7w_406694562")]
    [DisplayName("Primary Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryCorpInvstr")]
    #endif
    [IsoXmlTag("PmryCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    #else
    public Organisation4? PrimaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_nGSxctE5Ed-BzquC8wXy7w_505508166")]
    [DisplayName("Secondary Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryCorpInvstr")]
    #endif
    [IsoXmlTag("ScndryCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    #else
    public Organisation4? SecondaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_nGSxc9E5Ed-BzquC8wXy7w_607095720")]
    [DisplayName("Other Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCorpInvstr")]
    #endif
    [IsoXmlTag("OthrCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation4? OtherCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation4? OtherCorporateInvestor { get; init; } 
    #else
    public Organisation4? OtherCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_nGSxdNE5Ed-BzquC8wXy7w_1864008544")]
    [DisplayName("Client Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntAcct")]
    #endif
    [IsoXmlTag("ClntAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Account5 ClientAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Account5 ClientAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account5 ClientAccount { get; init; } 
    #else
    public Account5 ClientAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_nGSxddE5Ed-BzquC8wXy7w_-1971968219")]
    [DisplayName("Nominee Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmneeAcct")]
    #endif
    [IsoXmlTag("NmneeAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account6? NomineeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account6? NomineeAccount { get; init; } 
    #else
    public Account6? NomineeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_nGSxdtE5Ed-BzquC8wXy7w_-1544376123")]
    [DisplayName("New Plan Manager")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewPlanMgr")]
    #endif
    [IsoXmlTag("NewPlanMgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ NewPlanManager { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ NewPlanManager { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ NewPlanManager { get; init; } 
    #else
    public PartyIdentification2Choice_ NewPlanManager { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_nGSxd9E5Ed-BzquC8wXy7w_1105734380")]
    [DisplayName("Product Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTrf")]
    #endif
    [IsoXmlTag("PdctTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PEPISATransfer5 ProductTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PEPISATransfer5 ProductTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PEPISATransfer5 ProductTransfer { get; init; } 
    #else
    public PEPISATransfer5 ProductTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_nGcicNE5Ed-BzquC8wXy7w_-2129233899")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RequestForPEPOrISAOrPortfolioInformationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForPEPOrISAOrPortfolioInformationV01.

