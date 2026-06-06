// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the transactions in the report.
/// </summary>
[IsoId("_EdmRceSmEe-qVZLXW4RRBw")]
[DisplayName("Securities Modification2")]
public record SecuritiesModification2
{
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_EmOB8eSmEe-qVZLXW4RRBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_EmOB8-SmEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_EmOB9eSmEe-qVZLXW4RRBw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus71Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Identifies the individual transaction.
    /// </summary>
    [IsoId("_EmOB9-SmEe-qVZLXW4RRBw")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    [MinLength(1)]
    public ValueList<SecuritiesModificationTransaction2> Modification { get; init; } = [];
}
