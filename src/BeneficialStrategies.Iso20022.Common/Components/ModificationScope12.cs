// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_RQNBotp-Ed-ak6NoX_4Aeg_-94512893")]
[DisplayName("Modification Scope")]
public record ModificationScope12
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RQNBo9p-Ed-ak6NoX_4Aeg_-94512874")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Information related to the account to be modified.
    /// </summary>
    [IsoId("_RQNBpNp-Ed-ak6NoX_4Aeg_251806449")]
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public required FinancialInstrument10 FundDetails { get; init; }
}
