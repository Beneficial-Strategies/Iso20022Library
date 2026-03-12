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
/// This record is an implementation of the camt.035.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Proprietary Format Investigation message type is used by financial institutions, with their own offices, and/or with other financial institutions with which they have established bilateral agreements.
/// Usage
/// The user should ensure that an existing standard message cannot be used before using the proprietary message.
/// As defined in the scope, this ProprietaryFormatInvestigation message may only be used when bilaterally agreed.
/// It is used as an envelope for a non standard message and provides means to manage an exception or investigation which falls outside the scope or capability of any other formatted message.
/// </summary>
[Description(@"Scope|The Proprietary Format Investigation message type is used by financial institutions, with their own offices, and/or with other financial institutions with which they have established bilateral agreements.|Usage|The user should ensure that an existing standard message cannot be used before using the proprietary message.|As defined in the scope, this ProprietaryFormatInvestigation message may only be used when bilaterally agreed.|It is used as an envelope for a non standard message and provides means to manage an exception or investigation which falls outside the scope or capability of any other formatted message.")]
[IsoId("_OT9RiNE_Ed-BzquC8wXy7w_-1238871994")]
[DisplayName("Proprietary Format Investigation V")]
public partial record ProprietaryFormatInvestigationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.035.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtryFrmtInvstgtn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.035.001.02";
    
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
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage Rule: the Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_OT9RidE_Ed-BzquC8wXy7w_2139879859")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment2 Assignment { get; init; } 
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_OT9RitE_Ed-BzquC8wXy7w_2139880168")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case2 Case { get; init; } 
    
    /// <summary>
    /// Proprietary information.
    /// </summary>
    [IsoId("_OT9Ri9E_Ed-BzquC8wXy7w_2139880260")]
    [DisplayName("Proprietary Data")]
    [IsoXmlTag("PrtryData")]
    public required ProprietaryData4 ProprietaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ProprietaryFormatInvestigationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ProprietaryFormatInvestigationV02.

