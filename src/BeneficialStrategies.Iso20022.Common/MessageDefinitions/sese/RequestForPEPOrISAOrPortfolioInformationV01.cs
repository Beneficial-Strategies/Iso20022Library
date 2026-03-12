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
    
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_nGJAdNE5Ed-BzquC8wXy7w_-903781955")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_nGJAddE5Ed-BzquC8wXy7w_-444791972")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_nGJAdtE5Ed-BzquC8wXy7w_-117865583")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_nGJAd9E5Ed-BzquC8wXy7w_-19048277")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_nGJAeNE5Ed-BzquC8wXy7w_-439253534")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_nGJAedE5Ed-BzquC8wXy7w_-280406209")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_nGSxcNE5Ed-BzquC8wXy7w_28973546")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_nGSxcdE5Ed-BzquC8wXy7w_406694562")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_nGSxctE5Ed-BzquC8wXy7w_505508166")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_nGSxc9E5Ed-BzquC8wXy7w_607095720")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation4? OtherCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_nGSxdNE5Ed-BzquC8wXy7w_1864008544")]
    [DisplayName("Client Account")]
    [IsoXmlTag("ClntAcct")]
    public required Account5 ClientAccount { get; init; } 
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_nGSxddE5Ed-BzquC8wXy7w_-1971968219")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account6? NomineeAccount { get; init; } 
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_nGSxdtE5Ed-BzquC8wXy7w_-1544376123")]
    [DisplayName("New Plan Manager")]
    [IsoXmlTag("NewPlanMgr")]
    public required PartyIdentification2Choice_ NewPlanManager { get; init; } 
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_nGSxd9E5Ed-BzquC8wXy7w_1105734380")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required PEPISATransfer5 ProductTransfer { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_nGcicNE5Ed-BzquC8wXy7w_-2129233899")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestForPEPOrISAOrPortfolioInformationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForPEPOrISAOrPortfolioInformationV01.

