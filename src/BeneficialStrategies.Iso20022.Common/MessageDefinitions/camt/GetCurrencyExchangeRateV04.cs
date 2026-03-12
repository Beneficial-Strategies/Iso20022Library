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



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.016.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetCurrencyExchangeRate message is sent by a member to the transaction administrator.
/// It is used to request information on static data maintained by the transaction administrator and related to currency exchange details as maintained for the system operations by the transaction administrator.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, i.e., not related to the transactions created into the system. The type of business information available can vary depending on the system.
/// When a system manages a pool of accounts in various currencies for a member, there is a need to maintain currency exchange details in between the various currencies and the reporting or base currency. The reporting or base currency is used to calculate the actual position of the members in terms of aggregate limits and balances and allow the system to contain risk within the defined and agreed boundaries. The currency exchange details can be fixed for the entire operational day, or regularly updated according to near real time market feeds.
/// At any point in time during operating hours of the system, the member can query the transaction administrator to get information about the static data related to a currency exchange details.
/// The member can request information based on the following elements:
/// - the currency to be converted (source currency)
/// - the currency into which the amount is converted (target currency)
/// This message will be replied to by a ReturnCurrencyExchangeRate message.
/// </summary>
[Description(@"Scope|The GetCurrencyExchangeRate message is sent by a member to the transaction administrator.|It is used to request information on static data maintained by the transaction administrator and related to currency exchange details as maintained for the system operations by the transaction administrator.|Usage|The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, i.e., not related to the transactions created into the system. The type of business information available can vary depending on the system.|When a system manages a pool of accounts in various currencies for a member, there is a need to maintain currency exchange details in between the various currencies and the reporting or base currency. The reporting or base currency is used to calculate the actual position of the members in terms of aggregate limits and balances and allow the system to contain risk within the defined and agreed boundaries. The currency exchange details can be fixed for the entire operational day, or regularly updated according to near real time market feeds.|At any point in time during operating hours of the system, the member can query the transaction administrator to get information about the static data related to a currency exchange details.|The member can request information based on the following elements:|- the currency to be converted (source currency)|- the currency into which the amount is converted (target currency)|This message will be replied to by a ReturnCurrencyExchangeRate message.")]
[IsoId("_jwlbdxbvEeiyVv5j1vf1VQ")]
[DisplayName("Get Currency Exchange Rate V")]
public partial record GetCurrencyExchangeRateV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.016.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetCcyXchgRate";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.016.001.04";
    
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
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbeRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; } 
    
    /// <summary>
    /// Definition of the currency exchange query.
    /// </summary>
    [IsoId("_jwlbexbvEeiyVv5j1vf1VQ")]
    [DisplayName("Currency Query Definition")]
    [IsoXmlTag("CcyQryDef")]
    public CurrencyQueryDefinition3? CurrencyQueryDefinition { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbfRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since GetCurrencyExchangeRateV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetCurrencyExchangeRateV04.

