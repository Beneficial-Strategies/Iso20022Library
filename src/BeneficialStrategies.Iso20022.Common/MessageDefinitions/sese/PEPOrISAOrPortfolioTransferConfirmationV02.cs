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
/// This record is an implementation of the sese.013.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a (old) plan manager, sends the PEPOrISAOrPortfolioTransferConfirmation message to the instructing party, eg, a (new) plan manager, to confirm the transfer of one or more PEP or ISA or portfolio products from the client&apos;s account at the old plan manager to the client&apos;s account at the new plan manager through a nominee account.
/// Usage
/// The PEPOrISAOrPortfolioTransferConfirmation message is used to confirm the transfer of one or more PEP or ISA or portfolio products.
/// The reference of each product transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original product transfer is specified in TransferInstructionReference. The message identification of the PEPOrISAPOrPortfolioTransferInstruction message in which the product transfers were conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(@"Scope|An executing party, eg, a (old) plan manager, sends the PEPOrISAOrPortfolioTransferConfirmation message to the instructing party, eg, a (new) plan manager, to confirm the transfer of one or more PEP or ISA or portfolio products from the client's account at the old plan manager to the client's account at the new plan manager through a nominee account.|Usage|The PEPOrISAOrPortfolioTransferConfirmation message is used to confirm the transfer of one or more PEP or ISA or portfolio products.|The reference of each product transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original product transfer is specified in TransferInstructionReference. The message identification of the PEPOrISAPOrPortfolioTransferInstruction message in which the product transfers were conveyed may also be quoted in RelatedReference.")]
[IsoId("_kezKy9E5Ed-BzquC8wXy7w_-1426890235")]
[DisplayName("PEP Or ISA Or Portfolio Transfer Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PEPOrISAOrPortfolioTransferConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.013.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PEPOrISAOrPrtflTrfConfV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.013.001.02";
    
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
    /// Constructs a PEPOrISAOrPortfolioTransferConfirmationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PEPOrISAOrPortfolioTransferConfirmationV02( MessageIdentification1 reqMessageReference,Account5 reqClientAccount,PartyIdentification2Choice_ reqNewPlanManager,PEPISATransfer4 reqProductTransfer )
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
    [IsoId("_kezKzNE5Ed-BzquC8wXy7w_2045616687")]
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
    [IsoId("_kezKzdE5Ed-BzquC8wXy7w_-1776508711")]
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
    [IsoId("_ke87wNE5Ed-BzquC8wXy7w_-1475441471")]
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
    [IsoId("_ke87wdE5Ed-BzquC8wXy7w_-1094027263")]
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
    [IsoId("_ke87wtE5Ed-BzquC8wXy7w_-1345302241")]
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
    [IsoId("_ke87w9E5Ed-BzquC8wXy7w_-1057165624")]
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
    /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_ke87xNE5Ed-BzquC8wXy7w_1311997483")]
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
    [IsoId("_ke87xdE5Ed-BzquC8wXy7w_1458836732")]
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
    [IsoId("_ke87xtE5Ed-BzquC8wXy7w_1788534354")]
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
    [IsoId("_ke87x9E5Ed-BzquC8wXy7w_1758058484")]
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
    [IsoId("_kfGswNE5Ed-BzquC8wXy7w_1391141115")]
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
    [IsoId("_kfGswdE5Ed-BzquC8wXy7w_-1657996907")]
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
    [IsoId("_kfGswtE5Ed-BzquC8wXy7w_-1518546709")]
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
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    [IsoId("_kfGsw9E5Ed-BzquC8wXy7w_713137154")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount11? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount11? CashAccount { get; init; } 
    #else
    public CashAccount11? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_kfGsxNE5Ed-BzquC8wXy7w_-671220762")]
    [DisplayName("Product Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTrf")]
    #endif
    [IsoXmlTag("PdctTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PEPISATransfer4 ProductTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PEPISATransfer4 ProductTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PEPISATransfer4 ProductTransfer { get; init; } 
    #else
    public PEPISATransfer4 ProductTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kfGsxdE5Ed-BzquC8wXy7w_-686452185")]
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


// Since PEPOrISAOrPortfolioTransferConfirmationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PEPOrISAOrPortfolioTransferConfirmationV02.

