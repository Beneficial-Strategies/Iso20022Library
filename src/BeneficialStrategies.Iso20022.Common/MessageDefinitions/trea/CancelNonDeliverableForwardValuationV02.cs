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
/// This record is an implementation of the trea.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the cancellation of the valuation of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// </summary>
[Description(@"Scope|The CancelNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the cancellation of the valuation of a non deliverable trade previously confirmed by the sender.|Usage|The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.")]
[IsoId("_MYoUotE8Ed-BzquC8wXy7w_-340131062")]
[DisplayName("Cancel Non Deliverable Forward Valuation V")]
public partial record CancelNonDeliverableForwardValuationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclNDFValtnV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.006.001.02";
    
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
    /// Provides references and date of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUo9E8Ed-BzquC8wXy7w_-745317673")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement2 TradeInformation { get; init; } 
    
    /// <summary>
    /// Specifies the trading side of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUpNE8Ed-BzquC8wXy7w_200370128")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public TradePartyIdentification3? TradingSideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUpdE8Ed-BzquC8wXy7w_67383181")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public TradePartyIdentification3? CounterpartySideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the amounts of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUptE8Ed-BzquC8wXy7w_-761938752")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public AmountsAndValueDate1? TradeAmounts { get; init; } 
    
    /// <summary>
    /// Specifies the valuation rate of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUp9E8Ed-BzquC8wXy7w_-748089195")]
    [DisplayName("Valuation Rate")]
    [IsoXmlTag("ValtnRate")]
    public AgreedRate1? ValuationRate { get; init; } 
    
    /// <summary>
    /// Specifies the valuation information of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUqNE8Ed-BzquC8wXy7w_-750859823")]
    [DisplayName("Valuation Information")]
    [IsoXmlTag("ValtnInf")]
    public ValuationData2? ValuationInformation { get; init; } 
    
    
    #nullable disable
    
}


// Since CancelNonDeliverableForwardValuationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CancelNonDeliverableForwardValuationV02.

