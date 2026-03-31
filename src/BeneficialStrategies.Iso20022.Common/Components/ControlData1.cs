// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the number of transactions and the control sum of the message.
/// </summary>
[IsoId("_RqlQiNp-Ed-ak6NoX_4Aeg_518525040")]
[DisplayName("Control Data")]
public record ControlData1
{
    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_RqlQidp-Ed-ak6NoX_4Aeg_518525132")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_RquacNp-Ed-ak6NoX_4Aeg_518525163")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }
}
