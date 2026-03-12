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



namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// This record is an implementation of the trea.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the amendment of the opening of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message is sent from a participant to a central settlement system to advise of the update of a previously sent notification and it contains a &quot;Related Reference&quot; to link it to the previous notification.
/// </summary>
[Description(@"Scope|The AmendNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the amendment of the opening of a non deliverable trade previously confirmed by the sender.|Usage|The message is sent from a participant to a central settlement system to advise of the update of a previously sent notification and it contains a ""Related Reference"" to link it to the previous notification.")]
[IsoId("_JB5pZNE8Ed-BzquC8wXy7w_1482836315")]
[DisplayName("Amend Non Deliverable Forward Opening V")]
public partial record AmendNonDeliverableForwardOpeningV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdNDFOpngV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.002.001.02";
    
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
    /// Provides references and date of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JB5pZdE8Ed-BzquC8wXy7w_993953355")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement2 TradeInformation { get; init; } 
    
    /// <summary>
    /// Specifies the trading side of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JB5pZtE8Ed-BzquC8wXy7w_305725624")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification3 TradingSideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JB5pZ9E8Ed-BzquC8wXy7w_982933420")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification3 CounterpartySideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the amounts of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JB5paNE8Ed-BzquC8wXy7w_639319897")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    
    /// <summary>
    /// Specifies the rate of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JB5padE8Ed-BzquC8wXy7w_-781054907")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public required AgreedRate1 AgreedRate { get; init; } 
    
    /// <summary>
    /// Specifies the valuation conditions of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JB5patE8Ed-BzquC8wXy7w_-1055579338")]
    [DisplayName("Valuation Conditions")]
    [IsoXmlTag("ValtnConds")]
    public required NonDeliverableForwardValuationConditions2 ValuationConditions { get; init; } 
    
    
    #nullable disable
    
}


// Since AmendNonDeliverableForwardOpeningV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendNonDeliverableForwardOpeningV02.

