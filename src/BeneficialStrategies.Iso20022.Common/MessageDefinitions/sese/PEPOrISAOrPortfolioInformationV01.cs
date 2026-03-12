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
/// This record is an implementation of the sese.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a (old) plan manager, sends the PEPOrISAOrPortfolioInformation message to the instructing party, eg, a (new) plan manager, to provide information about financial instruments held on behalf of a client.
/// Usage
/// The PEPOrISAOrPortfolioInformation message is used to provide information about one or more PEP or ISA or portfolio products held in a client&apos;s account.
/// </summary>
[Description(@"Scope|An executing party, eg, a (old) plan manager, sends the PEPOrISAOrPortfolioInformation message to the instructing party, eg, a (new) plan manager, to provide information about financial instruments held on behalf of a client.|Usage|The PEPOrISAOrPortfolioInformation message is used to provide information about one or more PEP or ISA or portfolio products held in a client's account.")]
[IsoId("_jbALcNE5Ed-BzquC8wXy7w_1754705295")]
[DisplayName("PEP Or ISA Or Portfolio Information V")]
public partial record PEPOrISAOrPortfolioInformationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PEPOrISAOrPrtflInfV01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.018.001.01";
    
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
    [IsoId("_jbALcdE5Ed-BzquC8wXy7w_288092160")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_jbALctE5Ed-BzquC8wXy7w_1558855537")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_jbALc9E5Ed-BzquC8wXy7w_1976288625")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_jbALdNE5Ed-BzquC8wXy7w_2105581934")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_jbALddE5Ed-BzquC8wXy7w_-1518937049")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_jbJ8cNE5Ed-BzquC8wXy7w_-1125518129")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_jbJ8cdE5Ed-BzquC8wXy7w_-763765015")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_jbJ8ctE5Ed-BzquC8wXy7w_-676952118")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_jbJ8c9E5Ed-BzquC8wXy7w_-324166555")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_jbJ8dNE5Ed-BzquC8wXy7w_-9246374")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation4? OtherCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_jbJ8ddE5Ed-BzquC8wXy7w_227174054")]
    [DisplayName("Client Account")]
    [IsoXmlTag("ClntAcct")]
    public required Account5 ClientAccount { get; init; } 
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_jbJ8dtE5Ed-BzquC8wXy7w_906885450")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account6? NomineeAccount { get; init; } 
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_jbTGYNE5Ed-BzquC8wXy7w_1026018669")]
    [DisplayName("New Plan Manager")]
    [IsoXmlTag("NewPlanMgr")]
    public required PartyIdentification2Choice_ NewPlanManager { get; init; } 
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_jbTGYdE5Ed-BzquC8wXy7w_-153289612")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required PEPISATransfer6 ProductTransfer { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_jbTGYtE5Ed-BzquC8wXy7w_1484084715")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since PEPOrISAOrPortfolioInformationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PEPOrISAOrPortfolioInformationV01.

