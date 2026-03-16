// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the standing instruction.
/// </summary>
[IsoId("_UJbRidp-Ed-ak6NoX_4Aeg_852863952")]
[DisplayName("Corporate Action Standing Instruction")]
public record CorporateActionStandingInstruction1
{
    /// <summary>
    /// Identifies whether the account Holders want their income to be paid net or gross of income tax (default is gross).
    /// </summary>
    [IsoId("_UJbRitp-Ed-ak6NoX_4Aeg_1113626304")]
    [DisplayName("Net Or Gross")]
    [IsoXmlTag("NetOrGrss")]
    public required StandingInstructionGrossNet1Code NetOrGross { get; init; }

    /// <summary>
    /// Provides information about the cash distribution standing instruction.
    /// </summary>
    [IsoId("_UJbRi9p-Ed-ak6NoX_4Aeg_-650296854")]
    [DisplayName("Cash Distribution Details")]
    [IsoXmlTag("CshDstrbtnDtls")]
    public required CashAccount17 CashDistributionDetails { get; init; }

    /// <summary>
    /// Provides information about the securities distribution standing instruction.
    /// </summary>
    [IsoId("_UJbRjNp-Ed-ak6NoX_4Aeg_949052482")]
    [DisplayName("Securities Distribution Details")]
    [IsoXmlTag("SctiesDstrbtnDtls")]
    public required SecuritiesAccount6 SecuritiesDistributionDetails { get; init; }

    /// <summary>
    /// Additional information about the standing instruction.
    /// </summary>
    [IsoId("_UJkbcNp-Ed-ak6NoX_4Aeg_1012038453")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
