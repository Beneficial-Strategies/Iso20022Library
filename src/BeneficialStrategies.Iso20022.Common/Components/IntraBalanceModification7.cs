// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Balance Modification7.
/// </summary>
[IsoId("_7tvrpTEyEe6g-ffJsqGiSA")]
[DisplayName("Intra Balance Modification7")]
public record IntraBalanceModification7
{
    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccount40? CashAccount { get; init; }

    /// <summary>
    /// Cash Account Owner.
    /// </summary>
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Cash Account Servicer.
    /// </summary>
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? CashAccountServicer { get; init; }

    /// <summary>
    /// Modification.
    /// </summary>
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public ValueList<IntraBalanceModification8> Modification { get; init; } = [];

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus71Choice_? ProcessingStatus { get; init; }
}
