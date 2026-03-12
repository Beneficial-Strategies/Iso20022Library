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



namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.049.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RoleAndBaselineAcceptance message is sent by a secondary bank to the matching application if it accepts to join the transaction based on the baseline and the role that it is expected to play.
/// Usage
/// The RoleAndBaselineAcceptance message is sent in response to a message that is a direct request to join a transaction.
/// </summary>
[Description(@"Scope|The RoleAndBaselineAcceptance message is sent by a secondary bank to the matching application if it accepts to join the transaction based on the baseline and the role that it is expected to play.|Usage|The RoleAndBaselineAcceptance message is sent in response to a message that is a direct request to join a transaction.")]
[IsoId("_tSUHeNE8Ed-BzquC8wXy7w_1282098535")]
[DisplayName("Role And Baseline Acceptance V")]
public partial record RoleAndBaselineAcceptanceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.049.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RoleAndBaselnAccptnc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01";
    
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
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_tSdRYNE8Ed-BzquC8wXy7w_1282098561")]
    [DisplayName("Acceptance Identification")]
    [IsoXmlTag("AccptncId")]
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the message that contained the baseline and is accepted.
    /// </summary>
    [IsoId("_tSdRYdE8Ed-BzquC8wXy7w_1662420594")]
    [DisplayName("Related Message Reference")]
    [IsoXmlTag("RltdMsgRef")]
    public required MessageIdentification1 RelatedMessageReference { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_tSdRYtE8Ed-BzquC8wXy7w_1282098638")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    
    #nullable disable
    
}


// Since RoleAndBaselineAcceptanceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RoleAndBaselineAcceptanceV01.

