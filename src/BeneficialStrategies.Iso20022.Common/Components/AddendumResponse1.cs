// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum message is used in conjunction with an authorisation or financial message to provide supplemental data above that required to complete an authorisation initiation or financial initiation. 
/// </summary>
[IsoId("_QmeFQf5mEeiLerArw36g0w")]
[DisplayName("Addendum Response")]
public partial record AddendumResponse1
{
    #nullable enable
    
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    [IsoId("_Qxpagf5mEeiLerArw36g0w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment16 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_Qxpag_5mEeiLerArw36g0w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_Qxpahf5mEeiLerArw36g0w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction92 Transaction { get; init; } 
    
    /// <summary>
    /// Outcome of the processing of the addendum initiation.
    /// </summary>
    [IsoId("_W12jMP5nEeiLerArw36g0w")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_Qxpaif5mEeiLerArw36g0w")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_Qxpai_5mEeiLerArw36g0w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
