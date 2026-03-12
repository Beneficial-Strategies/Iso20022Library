// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be honoured on the presentation of documents that comply with its terms and conditions.
/// </summary>
[IsoId("_916yAnltEeG7BsjMvd1mEw_562975782")]
[DisplayName("Undertaking")]
public partial record Undertaking2
{
    #nullable enable
    
    /// <summary>
    /// Undertaking name.
    /// </summary>
    [IsoId("_8Skgo4LIEeGwNp5ZjMErfw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public UndertakingName1Code? Name { get; init; } 
    
    /// <summary>
    /// Party in whose favour the counter-undertaking is issued.
    /// </summary>
    [IsoId("_916yA3ltEeG7BsjMvd1mEw_1423077489")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public PartyIdentification43? Beneficiary { get; init; } 
    
    /// <summary>
    /// Details related to the expiry terms of the counter-undertaking.
    /// </summary>
    [IsoId("_nltCUhR7EeKyNbjzgBLUcA")]
    [DisplayName("Expiry Details")]
    [IsoXmlTag("XpryDtls")]
    public ExpiryDetails2? ExpiryDetails { get; init; } 
    
    /// <summary>
    /// Details related to the amount of the counter-undertaking.
    /// </summary>
    [IsoId("_916yBXltEeG7BsjMvd1mEw_-1180399069")]
    [DisplayName("Counter Undertaking Amount")]
    [IsoXmlTag("CntrUdrtkgAmt")]
    public UndertakingAmount1? CounterUndertakingAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_92D78HltEeG7BsjMvd1mEw_1953031282")]
    [DisplayName("Confirmation Charges Payable By")]
    [IsoXmlTag("ConfChrgsPyblBy")]
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    
    /// <summary>
    /// Rules and laws governing the counter-undertaking.
    /// </summary>
    [IsoId("_92D78XltEeG7BsjMvd1mEw_-138238292")]
    [DisplayName("Governance Rules And Law")]
    [IsoXmlTag("GovncRulesAndLaw")]
    public GovernanceRules1? GovernanceRulesAndLaw { get; init; } 
    
    /// <summary>
    /// Indication as to whether a claim is to utilise a standard claim form of the issuing institution.
    /// </summary>
    [IsoId("_92D78nltEeG7BsjMvd1mEw_816197846")]
    [DisplayName("Standard Claim Document Indicator")]
    [IsoXmlTag("StdClmDocInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StandardClaimDocumentIndicator { get; init; } 
    
    /// <summary>
    /// Additional information related to the counter-undertaking.
    /// </summary>
    [IsoId("_92D783ltEeG7BsjMvd1mEw_1702800733")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
