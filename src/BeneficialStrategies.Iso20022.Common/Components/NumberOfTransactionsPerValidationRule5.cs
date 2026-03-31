// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number of individual reports or transactions received / sent, detailed per validation rule.
/// </summary>
[IsoId("_TiPqwcrdEeii_5g6VX90qQ")]
[DisplayName("Number Of Transactions Per Validation Rule")]
public record NumberOfTransactionsPerValidationRule5
{
    /// <summary>
    /// Number of individual reports or transactions sent / received, detailed per status.
    /// </summary>
    [IsoId("_Tr7yQcrdEeii_5g6VX90qQ")]
    [DisplayName("Detailed Number")]
    [IsoXmlTag("DtldNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumber { get; init; }

    /// <summary>
    /// Common validation rule for all individual reports received.
    /// </summary>
    [IsoId("_Tr7yQ8rdEeii_5g6VX90qQ")]
    [DisplayName("Report Status")]
    [IsoXmlTag("RptSts")]
    public ValueList<RejectionReason45> ReportStatus { get; init; } = [];
    // ID for the above is _Tr7yQ8rdEeii_5g6VX90qQ
}
