// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Balance Query Criteria12.
/// </summary>
[IsoId("_70w5pTEyEe6g-ffJsqGiSA")]
[DisplayName("Intra Balance Query Criteria12")]
public partial record IntraBalanceQueryCriteria12
{
    #nullable enable

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> CashAccount { get; init; } = [];

    /// <summary>
    /// Cash Account Owner.
    /// </summary>
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public ValueList<SystemPartyIdentification8> CashAccountOwner { get; init; } = [];

    /// <summary>
    /// Cash Account Servicer.
    /// </summary>
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? CashAccountServicer { get; init; } 

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeSearch5Choice_? CreationDateTime { get; init; } 

    /// <summary>
    /// Message Originator.
    /// </summary>
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = [];

    /// <summary>
    /// Modification Request Identification.
    /// </summary>
    [DisplayName("Modification Request Identification")]
    [IsoXmlTag("ModReqId")]
    public ValueList<IsoMax35Text> ModificationRequestIdentification { get; init; } = [];

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ModificationProcessingStatus9Choice_> ProcessingStatus { get; init; } = [];

    
    #nullable disable
    
}
