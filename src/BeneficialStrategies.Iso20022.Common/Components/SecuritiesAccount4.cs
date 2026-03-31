// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_QT2uIdp-Ed-ak6NoX_4Aeg_-1963844796")]
[DisplayName("Securities Account")]
public record SecuritiesAccount4
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_QT2uItp-Ed-ak6NoX_4Aeg_-1963844770")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1 Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_QT2uI9p-Ed-ak6NoX_4Aeg_-1963844693")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Name { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_QT2uJNp-Ed-ak6NoX_4Aeg_-1963844580")]
    [DisplayName("Financial Instrument Supplementary Identification")]
    [IsoXmlTag("FinInstrmSplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FinancialInstrumentSupplementaryIdentification { get; init; }

    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_QT2uJdp-Ed-ak6NoX_4Aeg_-1963844658")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification3Choice_? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_QT2uJtp-Ed-ak6NoX_4Aeg_-1963844623")]
    [DisplayName("Financial Instrument Name")]
    [IsoXmlTag("FinInstrmNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FinancialInstrumentName { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_QT2uJ9p-Ed-ak6NoX_4Aeg_-1963844736")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AccountStatus1Code Status { get; init; }
}
