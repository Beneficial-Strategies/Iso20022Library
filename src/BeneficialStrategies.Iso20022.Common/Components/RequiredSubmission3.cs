// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of the insurance data set.
/// </summary>
[IsoId("_Rax58tp-Ed-ak6NoX_4Aeg_-1897093654")]
[DisplayName("Required Submission")]
public partial record RequiredSubmission3
{
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_Rax589p-Ed-ak6NoX_4Aeg_-1897093637")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public ValueList<BICIdentification1> Submitter { get; init; } = [];
    // ID for the above is _Rax589p-Ed-ak6NoX_4Aeg_-1897093637
    
    /// <summary>
    /// Specifies if the issuer must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax59Np-Ed-ak6NoX_4Aeg_1704101757")]
    [DisplayName("Match Issuer")]
    [IsoXmlTag("MtchIssr")]
    public PartyIdentification27? MatchIssuer { get; init; } 
    
    /// <summary>
    /// Specifies if the issue date must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax59dp-Ed-ak6NoX_4Aeg_-1540614996")]
    [DisplayName("Match Issue Date")]
    [IsoXmlTag("MtchIsseDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MatchIssueDate { get; init; } 
    
    /// <summary>
    /// Specifies if the transport information must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax59tp-Ed-ak6NoX_4Aeg_-1514758562")]
    [DisplayName("Match Transport")]
    [IsoXmlTag("MtchTrnsprt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MatchTransport { get; init; } 
    
    /// <summary>
    /// Specifies if the insured amount must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax599p-Ed-ak6NoX_4Aeg_-1037296621")]
    [DisplayName("Match Amount")]
    [IsoXmlTag("MtchAmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MatchAmount { get; init; } 
    
    /// <summary>
    /// Specifies which clauses are required in the insurance data set.
    /// </summary>
    [IsoId("_Rax5-Np-Ed-ak6NoX_4Aeg_-1000355227")]
    [DisplayName("Clauses Required")]
    [IsoXmlTag("ClausesReqrd")]
    public InsuranceClauses1Code? ClausesRequired { get; init; } 
    
    /// <summary>
    /// Specifies if the assured (insured) party must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Ra7q8Np-Ed-ak6NoX_4Aeg_-711292782")]
    [DisplayName("Match Assured Party")]
    [IsoXmlTag("MtchAssrdPty")]
    public AssuredType1Code? MatchAssuredParty { get; init; } 
    
    
    #nullable disable
    
}
