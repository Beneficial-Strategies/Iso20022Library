// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria based on which information is included.
/// </summary>
[IsoId("_3_TRNTp8EemwKdP955WBJQ")]
[DisplayName("Intra Balance Query Criteria")]
public record IntraBalanceQueryCriteria8
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_4JuYgTp8EemwKdP955WBJQ")]
    [DisplayName("Modification Request Identification")]
    [IsoXmlTag("ModReqId")]
    public SimpleValueList<IsoMax35Text> ModificationRequestIdentification { get; init; } = [];

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_4JuYiTp8EemwKdP955WBJQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ModificationProcessingStatus9Choice_> ProcessingStatus { get; init; } = [];

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_4JuYizp8EemwKdP955WBJQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> CashAccount { get; init; } = [];

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_4JuYjTp8EemwKdP955WBJQ")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public ValueList<SystemPartyIdentification8> CashAccountOwner { get; init; } = [];

    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_x9Y8oTp9EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_4JuYjzp8EemwKdP955WBJQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = [];

    /// <summary>
    /// Specifies the creation date/time of the intra-balance movement.
    /// </summary>
    [IsoId("_4JuYkTp8EemwKdP955WBJQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeSearch5Choice_? CreationDateTime { get; init; }
}
