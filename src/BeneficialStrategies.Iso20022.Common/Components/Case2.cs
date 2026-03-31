// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a case.
/// </summary>
[IsoId("_SpAnptp-Ed-ak6NoX_4Aeg_-1565053133")]
[DisplayName("Case")]
public record Case2
{
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_SpAnp9p-Ed-ak6NoX_4Aeg_-1565053102")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party that created the investigation case.
    /// </summary>
    [IsoId("_SpAnqNp-Ed-ak6NoX_4Aeg_-1667764151")]
    [DisplayName("Creator")]
    [IsoXmlTag("Cretr")]
    public required Party7Choice_ Creator { get; init; }

    /// <summary>
    /// Indicates whether or not the case was previously closed and is now re-opened.
    /// </summary>
    [IsoId("_SpAnqdp-Ed-ak6NoX_4Aeg_-1565052762")]
    [DisplayName("Reopen Case Indication")]
    [IsoXmlTag("ReopCaseIndctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReopenCaseIndication { get; init; }
}
