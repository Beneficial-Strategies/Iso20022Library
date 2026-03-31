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
[IsoId("_0UG7mSC6EeWPMvNwVtiMsA")]
[DisplayName("Modification Scope")]
public record ModificationScope29
{
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_0xIOkSC6EeWPMvNwVtiMsA")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Detailed information about the investment fund or security associated to the account.
    /// </summary>
    [IsoId("_0xIOkyC6EeWPMvNwVtiMsA")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument51 FinancialInstrumentDetails { get; init; }
}
