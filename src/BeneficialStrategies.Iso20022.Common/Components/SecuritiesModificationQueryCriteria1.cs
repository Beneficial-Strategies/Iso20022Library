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
[IsoId("_W1EGwWdnEemMLeaDfmIfIA")]
[DisplayName("Securities Modification Query Criteria1")]
public record SecuritiesModificationQueryCriteria1
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_XB0wYWdnEemMLeaDfmIfIA")]
    [DisplayName("Modification Request Identification")]
    [IsoXmlTag("ModReqId")]
    public SimpleValueList<IsoMax35Text> ModificationRequestIdentification { get; init; } = [];

    /// <summary>
    /// Type of underlying transaction to be modified, such as an settlement instruction or an intra-position movement.
    /// </summary>
    [IsoId("_XB0waWdnEemMLeaDfmIfIA")]
    [DisplayName("Instruction Query Type")]
    [IsoXmlTag("InstrQryTp")]
    public required InstructionQueryType1Code InstructionQueryType { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_XB0wa2dnEemMLeaDfmIfIA")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ModificationProcessingStatus9Choice_> ProcessingStatus { get; init; } = [];

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_XB0wbWdnEemMLeaDfmIfIA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public ValueList<SecuritiesAccount19> SafekeepingAccount { get; init; } = [];

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_XB0wb2dnEemMLeaDfmIfIA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public ValueList<SystemPartyIdentification8> AccountOwner { get; init; } = [];

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_XB0wcWdnEemMLeaDfmIfIA")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = [];

    /// <summary>
    /// Specifies the creation date/time of the intra-position movement.
    /// </summary>
    [IsoId("_XB0wc2dnEemMLeaDfmIfIA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeSearch5Choice_? CreationDateTime { get; init; }
}
